using HRManagementSystem.Business.DTO_s.EmployeeDto_s;
using HRManagementSystem.Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementSystem.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeesController : ControllerBase
{
    private readonly IEmployeeService _employeeService;

    public EmployeesController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _employeeService.GetAll());
    }

    [HttpPost]
    public async Task<IActionResult> Post(EmployeePostDto employeePostDto)
    {
        await _employeeService.Create(employeePostDto);
        return Ok("Employee Created");
    }
}
