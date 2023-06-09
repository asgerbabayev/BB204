using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace BB204_ChatApp.Models;

public class AppUser : IdentityUser
{
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;
    [NotMapped]
    public string FullName => $"{Name} {Surname}";
    public bool Status { get; set; }

    public string? Image { get; set; }
}
