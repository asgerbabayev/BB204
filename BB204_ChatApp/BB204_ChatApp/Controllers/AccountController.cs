using BB204_ChatApp.Models;
using BB204_ChatApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BB204_ChatApp.Controllers;

public class AccountController : Controller
{
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;
    private readonly IWebHostEnvironment _env;

    public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IWebHostEnvironment env)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _env = env;
    }

    public IActionResult Register()
    {
        if (User.Identity.IsAuthenticated) return RedirectToAction("Index", "Home");
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterVM registerVM)
    {
        if (!ModelState.IsValid) return View();
        AppUser newUser = new AppUser()
        {
            Name = registerVM.Name,
            Surname = registerVM.Surname,
            Email = registerVM.Email,
            UserName = registerVM.UserName,
        };

        if (registerVM.Image != null)
        {
            string fileName = Guid.NewGuid() + "_" + registerVM.Image.FileName;
            string path = Path.Combine(_env.WebRootPath, "imgs", fileName);
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await registerVM.Image.CopyToAsync(stream);
            }
            newUser.Image = fileName;
        }
        else newUser.Image = "face.jpeg";

        var result = await _userManager.CreateAsync(newUser, registerVM.Password);
        if (!result.Succeeded)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
            return View();
        }
        return RedirectToAction("Login");
    }

    public IActionResult Login()
    {
        if (User.Identity.IsAuthenticated) return RedirectToAction("Index", "Home");
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Login(LoginVM loginVM)
    {
        AppUser existUser = await _userManager.FindByNameAsync(loginVM.UserName);
        if (existUser == null)
        {
            ModelState.AddModelError("", "Invalid Credentials");
            return View();
        }
        var result = await _signInManager.PasswordSignInAsync(existUser, loginVM.Password, loginVM.RememberMe, false);
        if (!result.Succeeded)
        {
            ModelState.AddModelError("", "Invalid Credentials");
            return View();
        }
        return RedirectToAction("Index", "Home");
    }


    public async Task<IActionResult> SignOut()
    {
        await _signInManager.SignOutAsync();
        return RedirectToAction("Login");
    }
}
