using Microsoft.AspNetCore.Mvc;

namespace _002.PartialView.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
