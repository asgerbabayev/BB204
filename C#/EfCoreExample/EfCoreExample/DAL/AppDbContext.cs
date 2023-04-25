using EfCoreExample.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCoreExample.DAL;

internal class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server = .; Database = BB203; Integrated Security = True");
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Country> Countries { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Student> Students { get; set; }

}
