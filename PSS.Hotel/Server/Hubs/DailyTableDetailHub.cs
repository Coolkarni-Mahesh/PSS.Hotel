using Microsoft.AspNetCore.SignalR;

namespace PSS.Hotel.Server.Hubs;

public class DailyTableDetailHub : Hub
{
    public async Task SendMessage()
    {
        await Clients.All.SendAsync("ReceiveMessage");
    }
}
