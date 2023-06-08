using System.ComponentModel.DataAnnotations;

namespace BB204_ChatApp.ViewModels;

public class LoginVM
{
    public string UserName { get; set; } = null!;
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;
    public bool RememberMe { get; set; }
}
