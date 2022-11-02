using _002.Collection.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _002.Collection.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult IndeX()
        {
            List<Game> games = new List<Game>();
            Game fallout = new Game()
            {
                Name = "Fallout 4",
                Platform = "Windows",
                Engine = "Creation Engine"
            };

            Game stalker = new Game()
            {
                Name = "S.T.A.L.K.E.R",
                Platform = "Windows",
                Engine = "X-Ray Engine"
            };

            Game masseffect = new Game()
            {
                Name = "Mass Effect",
                Platform = "Windows",
                Engine = "Unreal Engine"
            };

            games.Add(fallout);
            games.Add(stalker);
            games.Add(masseffect);

            return View(games);
        }

    }
}
