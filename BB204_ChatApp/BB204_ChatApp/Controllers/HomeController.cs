using BB204_ChatApp.Models;
using BB204_ChatApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BB204_ChatApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public HomeController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                CurrentUser = await _userManager.FindByNameAsync(User.Identity.Name),
                OtherUsers = await _userManager.Users.Where(x => x.UserName != User.Identity.Name).ToListAsync(),
            };
            return View(homeVM);

        }
    }
}