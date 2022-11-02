using _003.MultipleClasses.Models;
using Microsoft.AspNetCore.Mvc;

namespace _003.MultipleClasses.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string ProceedResult(User[] users)
        {
            string result = "";
            foreach (var user in users)
            {
                result += $"Name: {user.Name}, Surname: {user.Surname}, Age: {user.Age}.\n";
            }
            return result;
        }
    }
}
