using System.Collections.Generic;
using _003.ViewModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace _003.ViewModel.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult IndeX()
        {
            PCGame fallout = new PCGame()
            {
                Name = "Fallout 4",
                Language = "C++",
            };
            PCGame stalker = new PCGame()
            {
                Name = "S.T.A.L.K.E.R",
                Language = "C++ & Lua Script",
            };
            PCGame masseffect = new PCGame()
            {
                Name = "Mass Effect",
                Language = "C++",
            };

            List<PCGame> PCGamesCollection = new List<PCGame>()
            {
                fallout, stalker, masseffect
            };


            XBoxGame minecraft = new XBoxGame()
            {
                Name = "Minecraft",
                Language = "Java",
            };
            XBoxGame obsolete = new XBoxGame()
            {
                Name = "Obsolete",
                Language = "C#",
            };
            XBoxGame crysis = new XBoxGame()
            {
                Name = "Crysis",
                Language = "C++",
            };

            List<XBoxGame> XBoxGamesCollection = new List<XBoxGame>()
            {
                minecraft, obsolete, crysis
            };

            var viewModel = new GamesViewModel()
            {
                PCGames = PCGamesCollection,
                XBoxGames = XBoxGamesCollection
            };

            return View(viewModel);
        }

    }
}
