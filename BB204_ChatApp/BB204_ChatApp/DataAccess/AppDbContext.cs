using BB204_ChatApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BB204_ChatApp.DataAccess;

public class AppDbContext : IdentityDbContext<AppUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<AppUser>().Property(x => x.Status).HasDefaultValue(false);
        base.OnModelCreating(builder);
    }
}
