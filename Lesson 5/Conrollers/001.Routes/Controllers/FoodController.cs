using _001.Routes.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _001.Routes.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult Companies()
        {
            List<PlainModel> models = new List<PlainModel>()
            {
                new PlainModel{Company="Nestle", Employees=10000,Salary=2000 },
                new PlainModel{Company="Sobeys", Employees=55000,Salary=30000 },
                new PlainModel{Company="Chocolove", Employees=8000,Salary=8000 }
            };
            return View(models);
        }
    }
}
