using BB204_ChatApp.DataAccess;
using BB204_ChatApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;

namespace BB204_ChatApp.Hubs;

public class ChatHub : Hub
{
    private readonly UserManager<AppUser> _userManager;
    private readonly AppDbContext _appDbContext;
    public ChatHub(UserManager<AppUser> userManager, AppDbContext appDbContext)
    {
        _userManager = userManager;
        _appDbContext = appDbContext;
    }

    public async Task SendMessage(string message)
    {
        string date = DateTime.UtcNow.ToString("hh:mm tt");
        var senderId = Context.User.Identity.Name;
        await Clients.All.SendAsync("ReceiveMessage", message, senderId, date);
    }


    public override Task OnConnectedAsync()
    {
        AppUser user = _userManager.FindByNameAsync(Context.User.Identity.Name).GetAwaiter().GetResult();
        user.ConnectionId = Context.ConnectionId;
        _appDbContext.SaveChangesAsync().GetAwaiter().GetResult();
        Clients.All.SendAsync("Connected", Context.User.Identity.Name);
        return base.OnConnectedAsync();
    }
    public override Task OnDisconnectedAsync(Exception? exception)
    {
        AppUser user = _userManager.FindByNameAsync(Context.User.Identity.Name).GetAwaiter().GetResult();
        user.ConnectionId = null;
        _appDbContext.SaveChanges();
        Clients.All.SendAsync("Disconnected", Context.User.Identity.Name);
        return base.OnDisconnectedAsync(exception);
    }
}
