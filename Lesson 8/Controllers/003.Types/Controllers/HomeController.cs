using Microsoft.AspNetCore.Mvc;

namespace _003.Types.Controllers
{
    public class HomeController : Controller
    {
        //[HttpGet]
        [HttpPost]
        //[HttpPut]
        //[HttpDelete]
        public IActionResult Index()
        {
            return View();
        }
         
    }
}
