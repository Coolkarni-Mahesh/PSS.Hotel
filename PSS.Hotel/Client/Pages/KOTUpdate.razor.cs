using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;

namespace PSS.Hotel.Client.Pages;

public partial class KOTUpdate
{
    [Parameter]
    public int KotNo { get; set; }

    private HubConnection? hubConnection;

    protected override async Task OnParametersSetAsync()
    {
        await DailyTableDetailService.GetByKotNo(KotNo);
    }
    async Task HandleSubmit()
    {
        try
        {
            foreach (var item in DailyTableDetailService.DailyTableDetails)
            {
                await DailyTableDetailService.Update(item);
            }
            if (IsConnected)
            {
                await SendMessage();
            }
            NavigationManager.NavigateTo("SupervisorScreen");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    Task SendMessage() => hubConnection!.SendAsync("SendMessage");

    protected override async Task OnInitializedAsync()
    {
        try
        {
            await TableNameService.GetAll();
            hubConnection = new HubConnectionBuilder().WithUrl(NavigationManager.ToAbsoluteUri("/DailyTableDetailHub")).Build();
            await hubConnection.StartAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    public bool IsConnected => hubConnection?.State == HubConnectionState.Connected;

    public void Dispose()
    {
        _ = hubConnection!.DisposeAsync();
    }
}
