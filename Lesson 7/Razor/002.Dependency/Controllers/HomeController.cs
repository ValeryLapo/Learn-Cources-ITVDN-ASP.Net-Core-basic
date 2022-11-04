using Microsoft.AspNetCore.Mvc;

namespace _002.Dependency.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
