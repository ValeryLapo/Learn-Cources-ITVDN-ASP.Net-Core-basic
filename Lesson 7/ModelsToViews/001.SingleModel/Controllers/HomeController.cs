using _001.SingleModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace _001.SingleModel.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            Game fallout = new Game()
            {
                Name = "Fallout 4",
                Platform = "Windows",
                Engine = "Creation Engine",
            };

            return View(fallout);
        }
    }
}
