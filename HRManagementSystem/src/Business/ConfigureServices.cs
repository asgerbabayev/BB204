using HRManagementSystem.Business.Services.Abstract;
using HRManagementSystem.Business.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace HRManagementSystem.Business;

public static class ConfigureServices
{
    public static IServiceCollection AddBusinessServices(this IServiceCollection services)
    {
        services.AddScoped<IEmployeeService, EmployeeManager>();
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        return services;
    }
}
