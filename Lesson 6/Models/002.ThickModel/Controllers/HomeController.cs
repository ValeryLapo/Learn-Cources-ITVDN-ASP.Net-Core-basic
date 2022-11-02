using _002.ThickModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace _002.ThickModel.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            Company microsoft = new Company("Microsoft", 50000);
            return microsoft.GetInfo(); 

        }
    }
}
