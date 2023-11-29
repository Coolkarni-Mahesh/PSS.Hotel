using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;

namespace PSS.Hotel.Client.Pages;

public partial class ItemUpdate
{
    [Parameter]
    public int? ID { get; set; }
    DailyTableDetail _dailyTableDetail = new DailyTableDetail();

    private HubConnection? hubConnection;
    protected override async Task OnInitializedAsync()
    {
        try
        {
            hubConnection = new HubConnectionBuilder().WithUrl(NavigationManager.ToAbsoluteUri("/DailyTableDetailHub")).Build();
            await hubConnection.StartAsync();
        }
        catch (Exception ex)
        {
               Console.WriteLine(ex.ToString());
        }
    }
    public bool IsConnected => hubConnection?.State == HubConnectionState.Connected;

    protected override async Task OnParametersSetAsync()
    {
        try
        {
            await DailyTableDetailService.GetByID(ID);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
    async Task HandleSubmit()
    {
        try
        {
            _dailyTableDetail = await DailyTableDetailService.Update(DailyTableDetailService.SingleDailyTableDetail);

            if (IsConnected)
                await SendMessage();

            NavigationManager.NavigateTo("SupervisorScreen");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    Task SendMessage() => hubConnection!.SendAsync("SendMessage");

    // async Task HandleSubmit1()
    // {
    //     //  await DailyTableDetailService.Update(DailyTableDetailService.SingleDailyTableDetail,ID);
    // }

    public void Dispose()
    {
        _ = hubConnection!.DisposeAsync();
    }

}
