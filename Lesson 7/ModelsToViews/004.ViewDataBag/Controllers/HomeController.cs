using Microsoft.AspNetCore.Mvc;

namespace _004.ViewDataBag.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            ViewData["Data"] = "ViewData usage.";
            ViewBag.DataBag = "ViewBag usage.";

            return View();
        }
    }
}
