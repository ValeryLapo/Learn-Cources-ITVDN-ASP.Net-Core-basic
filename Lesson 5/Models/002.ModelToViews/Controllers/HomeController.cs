using _002.ModelToViews.Models;
using Microsoft.AspNetCore.Mvc;

namespace _002.ModelToViews.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            PlainModel model = new PlainModel()
            {
                Company="Microsoft",
                Employees = 100000,
                Salary = 10000
            };

            ViewData["totalSalary"] = model.Employees * model.Salary;
            ViewData["company"] = model.Company;
            ViewData["employees"] = model.Employees;
            return View();
        }
    }
}
