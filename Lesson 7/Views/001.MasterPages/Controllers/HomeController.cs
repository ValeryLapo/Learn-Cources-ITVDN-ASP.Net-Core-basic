﻿using Microsoft.AspNetCore.Mvc;

namespace _001.MasterPages.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
