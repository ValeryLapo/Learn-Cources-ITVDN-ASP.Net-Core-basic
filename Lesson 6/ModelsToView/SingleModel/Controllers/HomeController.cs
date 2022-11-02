using Microsoft.AspNetCore.Mvc;
using SingleModel.Models;

namespace SingleModel.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult IndeX()
        {
            Game fallout = new Game()
            {
                Name = "Fallout 4",
                Platform = "Windows",
                Engine = "Creation Engine"
            };

            return View(fallout);
        }

    }
}
