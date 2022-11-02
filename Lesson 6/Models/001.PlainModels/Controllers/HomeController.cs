using _001.PlainModels.Models;
using Microsoft.AspNetCore.Mvc;

namespace _001.PlainModels.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            Company microsoft = new Company()
            {
                Name = "Microsoft",
                Employees = 50000
            };

            string result = $"Name: {microsoft.Name}, Employees: {microsoft.Employees}";
            return result;
        }

        public string Car()
        {
            Company microsoft = new Company()
            {
                Name = "Toyota",
                Employees = 22314
            };

            string result = $"Name: {microsoft.Name}, Employees: {microsoft.Employees}";
            return result;
        }
    }
}
