using System.ComponentModel.DataAnnotations;

namespace BB204_ChatApp.ViewModels;

public class RegisterVM
{
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;
    public string UserName { get; set; } = null!;
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;
    [DataType(DataType.Password), Compare(nameof(Password))]
    public string ConfirmPassword { get; set; } = null!;
}
