using BB204_ChatApp.Models;

namespace BB204_ChatApp.ViewModels;

public class HomeVM
{
    public AppUser CurrentUser { get; set; }
    public List<AppUser> OtherUsers { get; set; }
}
