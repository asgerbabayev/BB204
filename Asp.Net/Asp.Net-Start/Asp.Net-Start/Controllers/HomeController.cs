﻿using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Start.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
