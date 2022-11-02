using _002.Class.Models;
using Microsoft.AspNetCore.Mvc;

namespace _002.Class.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string ProceedResult(User user)
        {
            return $"Name: {user.Name}, Surname: {user.Surname}, Age: {user.Age}";
        }
    }
}
