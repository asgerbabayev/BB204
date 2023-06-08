using Microsoft.AspNetCore.Identity;

namespace JwtExample.Data.Entities.Identity;

public class AppUser : IdentityUser
{
    public string FullName { get; set; } = null!;
}
