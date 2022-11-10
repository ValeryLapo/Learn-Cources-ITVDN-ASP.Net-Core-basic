using _001.Results.Models;
using Microsoft.AspNetCore.Mvc;

namespace _001.Results.Controllers
{
    [NonController]
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    return "Hello world!";
        //}

        //public bool Index()
        //{
        //    return true;
        //}

        //public User Index()
        //{
        //    return new User() {Name = "Alex", Surname = "Ross"};
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Index()
        //{
        //    return View(@"Views\Alt\Alt.cshtml");
        //}

        public IActionResult Index()
        {
            return View(@"../Alternative/Alt");
        }

    }
}
