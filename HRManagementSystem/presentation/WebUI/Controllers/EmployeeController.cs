using Microsoft.AspNetCore.Mvc;

namespace HRManagementSystem.WebUI.Controllers;

public class EmployeeController : Controller
{
    public IActionResult Create()
    {
        return View();
    }
}
