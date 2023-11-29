namespace PSS.Hotel.Client.Pages;

public partial class SupervisorScreen
{
    string TitleName = "KOT-Wise Status";
    string? Search;
    List<int?> kotNoList = new List<int?>();

    int? KotBotNo;

    List<ItemwiseModel> ItemwiseTableModelList = new List<ItemwiseModel>();
    List<ItemwiseModel> ItemwiseTableModelList1 = new List<ItemwiseModel>();

    List<DailyTable_DTO> _dailyTableList = new List<DailyTable_DTO>();
    List<DailyTableDetail_DTO> _dailyTableDetailList = new List<DailyTableDetail_DTO>();

    protected override async Task OnInitializedAsync()
    {
        try
        {
            await DailyTableService.GetAll();
            await DailyTableDetailService.GetAll();
            await EmployeeMasterService.GetAll();
            await ItemwiseTableService.GetAll();
            await TableNameService.GetAll();
            Load();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
    private void Load()
    {
        try
        {
            foreach (var item in DailyTableService.DailyTables)
            {
                DailyTable_DTO dailyTable_DTO = new DailyTable_DTO()
                {
                    TableName = item.TableId.ToString(),
                    CaptainName = EmployeeMasterService.Employees.Where(temp => temp.Empno == item.CaptainCode).Select(temp => temp.AliasName).FirstOrDefault(),
                    WaiterName = EmployeeMasterService.Employees.Where(temp => temp.Empno == item.WetterCode).Select(temp => temp.AliasName).FirstOrDefault(),
                    CustomerName = item.CustName,
                    Time = Convert.ToDateTime(item.StartTime)
                };
                _dailyTableList.Add(dailyTable_DTO);
            }

            foreach (var item in DailyTableDetailService.DailyTableDetails.Where(temp => temp.Kotbot == "K"))
            {
                DailyTableDetail_DTO dailyTableDetail_DTO = new DailyTableDetail_DTO()
                {
                    TableName = item.TableNo.ToString(),
                    ItemName = item.itemMaster?.ItemName,
                    KOTMsg = item.Kotmsg,
                    // StartTime = Convert.ToDateTime(item.StartTime),
                    StartTime = DateTime.Parse(item.StartTime!),
                    Delivered = item.Delivered,
                    Pending = item.Pending,
                    Ready = item.Ready,
                    Cooking = item.Cooking,
                    Cancel = Convert.ToInt32(item.Cancel),
                    KotNo = item.KotNo,
                    DailyTableDetailID = item.DailyTableDetailId,
                    Qty = item.Order

                };
                _dailyTableDetailList.Add(dailyTableDetail_DTO);
            }

            foreach (var item in _dailyTableList)
            {
                foreach (var item1 in _dailyTableDetailList
                    .OrderBy(temp => temp.ItemName)
                    .Where(temp => temp.TableName == item.TableName).DistinctBy(temp => new { temp.ItemName, temp.KOTMsg }).ToList())
                {
                    ItemwiseModel ItemwiseTable = new ItemwiseModel()
                    {
                        TableName = item1.TableName,
                        KotNo = item1.KotNo,
                        CaptainName = item.CaptainName,
                        WaiterName = item.WaiterName,
                        CustomerName = item.CustomerName,
                        StartTime = item1.StartTime,
                        ItemName = item1.ItemName + ((item1.KOTMsg != "-") ? " [ " + item1.KOTMsg + " ] " : ""),
                        KOTMessage = item1.KOTMsg,
                        NoOfPendingItem = item1.Pending,
                        NoOfCookingItem = item1.Cooking,
                        NoOfCancelItem = item1.Cancel,
                        NoOfDeliveredItem = item1.Delivered,
                        NoOfReadyItem = item1.Ready,
                        DailyTableDetailID = item1.DailyTableDetailID,
                        NoOfQuantity = item1.Qty
                    };
                    ItemwiseTableModelList.Add(ItemwiseTable);
                }
            }

            // var k = ItemwiseTableModelList.OrderBy(temp => temp.ItemName)
            // .GroupBy(ItemwiseTableModelList => new { ItemwiseTableModelList.ItemName, ItemwiseTableModelList.KOTMessage })
            // .Select(group => new
            // {
            //     TableName,

            //     ItemName = group.Key.ItemName + ((group.Key.KOTMessage == "-") ? "" : "         [ " + group.Key.KOTMessage + " ] "),

            //     NoOfPendingItem = group.Sum(item => item.NoOfPendingItem),
            //     NoOfCookingItem = group.Sum(item => item.NoOfCookingItem),
            //     NoOfCancelItem = group.Sum(item => item.NoOfCancelItem)
            // });
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
    void ShowItem(int? ID)
    {
        NavigationManager.NavigateTo($"Itemwise/{ID}");
    }
    void UpdateKOT(int? KotNo)
    {
        NavigationManager.NavigateTo($"KotUpdate/{KotNo}");
    }
}
