using _001.Routes.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _001.Routes.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Companies()
        {
            List<PlainModel> models = new List<PlainModel>()
            {
                new PlainModel{Company="Toyota", Employees=10000,Salary=2000 },
                new PlainModel{Company="Audi", Employees=55000,Salary=30000 },
                new PlainModel{Company="Volvo", Employees=8000,Salary=8000 }
            };
            return View(models);
        }
    }
}
