using Microsoft.AspNetCore.SignalR.Client;

namespace PSS.Hotel.Client.Pages;

public partial class ItemwiseTable
{

    string TitleName = "Item-Wise Status";
    List<ItemwiseModel> ItemwiseTableModelList = new List<ItemwiseModel>();
    List<ItemwiseModel> ItemwiseTableModelList1 = new List<ItemwiseModel>();


    private HubConnection? hubConnection;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            hubConnection = new HubConnectionBuilder().WithUrl(NavigationManager.ToAbsoluteUri("/DailyTableDetailHub")).Build();
            hubConnection.On("ReceiveMessage", () =>
            {
                CallLoadData();
                StateHasChanged();
            });

            await hubConnection.StartAsync();
            await LoadData();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
    private void CallLoadData()
    {
        try
        {
            Task.Run(async () =>
            {
                await LoadData();
            });

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
    protected async Task LoadData()
    {
        try
        {
            ItemwiseTableModelList.Clear();
            ItemwiseTableModelList1.Clear();

            await ItemwiseTableService.GetAll();
            await TableNameService.GetAll();


            int kkkk = ItemwiseTableService.DailyTableDetails.Count();
            var mkmk = ItemwiseTableService.DailyTableDetails;

            foreach (var item in ItemwiseTableService.DailyTableDetails)
            {
                ItemwiseModel ItemwiseTable = new ItemwiseModel()
                {
                    ItemName = item.itemMaster?.ItemName!,
                    TableName = TableNameService.TableNames.FirstOrDefault(temp => temp.TableId == item.TableNo)?.TableName1,
                    NoOfQuantity = item.Order,
                    NoOfPendingItem = item.Pending,
                    NoOfDeliveredItem = item.Delivered,
                    NoOfCookingItem = item.Cooking,
                    NoOfReadyItem = item.Ready,
                    NoOfCancelItem = Convert.ToInt32(item.Cancel),
                    KOTMessage = item.Kotmsg
                };
                ItemwiseTableModelList.Add(ItemwiseTable);
            }
            var k = ItemwiseTableModelList.OrderBy(temp => temp.ItemName)
            .GroupBy(ItemwiseTableModelList => new { ItemwiseTableModelList.ItemName, ItemwiseTableModelList.KOTMessage })
            .Select(group => new
            {

                ItemName = group.Key.ItemName + ((group.Key.KOTMessage == "-") ? "" : "         [ " + group.Key.KOTMessage + " ] "),
                TableName = string.Join(", ", group.Select(item => item.TableName).Distinct()),
                NoOfQuantity = group.Sum(item => item.NoOfQuantity),
                NoOfPendingItem = group.Sum(item => item.NoOfPendingItem),
                NoOfDeliveredItem = group.Sum(item => item.NoOfDeliveredItem),
                NoOfCookingItem = group.Sum(item => item.NoOfCookingItem),
                NoOfReadyItem = group.Sum(item => item.NoOfReadyItem),
                NoOfCancelItem = group.Sum(item => item.NoOfCancelItem)

            });

            // var k = from dailyTableDetail in ItemwiseTableModelList
            //         group dailyTableDetail by dailyTableDetail.ItemName into grouped
            //         select new
            //         {
            //             ItemName = grouped.Key,

            //             NoOfPendingItem = grouped.Sum(item => item.NoOfPendingItem),
            //             NoOfCookingItem = grouped.Sum(item => item.NoOfCookingItem),
            //             NoOfCancelItem = grouped.Sum(item => item.NoOfCancelItem)

            //         } ;


            foreach (var item in k)
            {
                ItemwiseModel model = new ItemwiseModel()
                {
                    ItemName = item.ItemName,
                    TableName = item.TableName,
                    NoOfQuantity = item.NoOfQuantity,
                    NoOfPendingItem = item.NoOfPendingItem,
                    NoOfDeliveredItem = item.NoOfDeliveredItem,
                    NoOfCookingItem = item.NoOfCookingItem,
                    NoOfReadyItem = item.NoOfReadyItem,
                    NoOfCancelItem = item.NoOfCancelItem
                };
                ItemwiseTableModelList1.Add(model);
            }
            StateHasChanged();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
    public void Dispose()
    {
        try
        {
            _ = hubConnection!.DisposeAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}
