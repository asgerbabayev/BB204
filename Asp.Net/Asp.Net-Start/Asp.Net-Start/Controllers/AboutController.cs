using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Start.Controllers
{
    public class AboutController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> Details()
        {
            return View();
        }
    }
}
