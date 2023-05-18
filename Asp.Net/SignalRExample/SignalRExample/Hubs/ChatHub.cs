using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace SignalRExample.Hubs;

[Authorize]
public class ChatHub : Hub
{
    static Dictionary<string, string> users = new Dictionary<string, string>();
    public override Task OnConnectedAsync()
    {
        return base.OnConnectedAsync();
    }
    public async Task SendMessage(string username, string group, string message)
    {
        await Clients.Group(group).SendAsync("ReceiveMessage", username, message);
    }

    public async Task AddGroup(string group)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, group);
    }
    public async Task RemoveGroup(string group)
    {
        await Groups.RemoveFromGroupAsync(Context.ConnectionId, group);
    }

    public async Task AddUsers(string username)
    {
        users.Add(Context.ConnectionId, username);
    }
}
