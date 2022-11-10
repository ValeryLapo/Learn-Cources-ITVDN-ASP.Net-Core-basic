using Microsoft.AspNetCore.Mvc;

namespace _002.Attributes.Controllers
{
    //[NonController]
    public class HomeController : Controller
    {
        //[NonAction]
        [ActionName("HELLO")]
        public IActionResult Index()
        {
            return View();
        }
         
    }
}
