using JwtExample.Data.Entities;
using JwtExample.Data.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WebApp.Data.Entities.Identity;

namespace JwtExample.Data.DataAccess;

public class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        //builder.Entity<Product>().HasData(
        //    new Product { Id = 1, Name = "Test 1", Count = 12, Price = 5 },
        //    new Product { Id = 2, Name = "Test 2", Count = 12, Price = 5 },
        //    new Product { Id = 3, Name = "Test 3", Count = 12, Price = 5 }
        //    );
        //builder.Entity<AppRole>().HasData(new AppRole { Name = "Admin"});
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
}
