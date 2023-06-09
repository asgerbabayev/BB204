using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HRManagementSystem.DataAccess;

public static class ConfigureServices
{
    public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(x => x.UseSqlServer(configuration.GetConnectionString("default")));
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        return services;
    }
}
