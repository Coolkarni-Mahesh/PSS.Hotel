using Microsoft.AspNetCore.SignalR.Client;

namespace PSS.Hotel.Client.Pages;

public partial class KOTPendingTables
{
    private HubConnection? hubConnection;

    string TitleName = "Table Status";

    List<KotPendingTableModel> KotPendingList = new List<KotPendingTableModel>();
    List<KotPendingTableModel> KotPendingList1 = new List<KotPendingTableModel>();

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
            KotPendingList.Clear();
            KotPendingList1.Clear();

            await DailyTableDetailService.GetAll();
            await TableNameService.GetAll();

            int NoDelivered = 0;

            var DailyTableDetailList = DailyTableDetailService.DailyTableDetails.Where(temp => temp.Kotbot == "K").ToList();
            var TableList = DailyTableDetailList.Select(temp => temp.TableNo).Distinct().ToList();

            for (int p = 0; p < TableList.Count(); p++)
            {
                NoDelivered = 0;
                var TableWiseList = DailyTableDetailList.Where(temp => temp.TableNo == TableList[p]).ToList();

                var KotNo = TableWiseList.Select(temp => temp.KotNo).Distinct().ToList();

                for (int q = 0; q < KotNo.Count(); q++)
                {
                    var kot = TableWiseList.Where(temp => temp.KotNo == KotNo[q]).ToList();

                    int flag = 0;

                    for (int x = 0; x < kot.Count(); x++)
                    {
                        if (kot[x].Order == kot[x].Delivered)
                        {
                            flag++;
                        }

                    }
                    if (kot.Count() == flag)
                    {
                        NoDelivered++;
                    }
                }
                //  Console.WriteLine("Table = " + TableList[p] + " Total KOT Qty = " + KotNo.Count() + " Delivered = " + NoDelivered + " Pending =  " + (KotNo.Count() - NoDelivered));
                KotPendingTableModel KOT = new KotPendingTableModel()
                {
                    TableName = TableNameService.TableNames.FirstOrDefault(temp => temp.TableId == TableList[p])?.TableName1,
                    TotalItemQty = KotNo.Count(),
                    DeliveredItemQty = NoDelivered,
                    PendingItemQty = (KotNo.Count() - NoDelivered),
                    ReadyItemQty = 0,
                    CancelItemQty = 0
                };
                KotPendingList1.Add(KOT);
            }

            // Old Code
            /*
                            foreach (var item in DailyTableDetailService.DailyTableDetails)
                            {
                                KotPendingTableModel KOT = new KotPendingTableModel()
                                    {
                                        TableName = item.TableNo.ToString(),
                                        TotalItemQty = (int)item.Order!,
                                        ReadyItemQty = item.Ready,
                                        PendingItemQty = item.Pending,
                                        CancelItemQty = (int)item.Cancel!,
                                        DeliveredItemQty = item.Delivered
                                    };
                                KotPendingList.Add(KOT);
                            }
                            var k = from dailyTableDetail in KotPendingList
                                    group dailyTableDetail by dailyTableDetail.TableName into grouped
                                    select new
                                    {
                                        TableName = grouped.Key,
                                        TotalItemQty = grouped.Sum(item => item.TotalItemQty),
                                        CancelItemQty = grouped.Sum(item => item.CancelItemQty),
                                        ReadyItemQty = grouped.Sum(item => item.ReadyItemQty),
                                        PendingItemQty = grouped.Sum(item => item.PendingItemQty),
                                        DeliveredItemQty = grouped.Sum(item => item.DeliveredItemQty)
                                    };
                            foreach (var item in k)
                            {

                                KotPendingTableModel KOT = new KotPendingTableModel()
                                    {
                                        TableName = item.TableName.ToString(),
                                        TotalItemQty = (int)item.TotalItemQty!,
                                        ReadyItemQty = item.ReadyItemQty,
                                        PendingItemQty = item.PendingItemQty,
                                        CancelItemQty = Convert.ToInt32(item.CancelItemQty),
                                        DeliveredItemQty = item.DeliveredItemQty
                                    };
                                KotPendingList1.Add(KOT);
                            }

                    */

            StateHasChanged();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Eror - LoadData()" + ex);
        }
    }
    protected override async Task OnInitializedAsync()
    {
        try
        {
            hubConnection = new HubConnectionBuilder().WithUrl(NavigationManager.ToAbsoluteUri("/DailyTabledetailHub")).Build();
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
            Console.WriteLine("Error - OnInitializedAsync()" + ex);
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
            Console.WriteLine("Error - Dispose()" + ex);
        }
    }
}
