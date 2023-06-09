using HRManagementSystem.Business.DTO_s.EmployeeDto_s;
using HRManagementSystem.Data.Entities;

namespace HRManagementSystem.Business.Services.Abstract;

public interface IEmployeeService
{
    Task Create(EmployeePostDto employeePostDto);
    Task Update(Employee employee);
    Task Remove(Employee employee);
    Task<EmployeeGetDto> Get(int id);
    Task<List<EmployeeGetDto>> GetAll();
}
