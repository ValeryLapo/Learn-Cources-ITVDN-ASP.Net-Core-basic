using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.WebEncoders.Testing;

namespace _002.Files.Controller
{
    public class HomeController: Microsoft.AspNetCore.Mvc.Controller
    {
        public readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(IWebHostEnvironment appEnvironment)
        {
            _webHostEnvironment = appEnvironment;
        }

        //public VirtualFileResult Index()
        //{
        //    var filePath = Path.Combine("~/Files", "Test.txt");
        //    return File(filePath, "Application/txt", "File.txt");
        //}

        //public IActionResult Index()
        //{
        //    //File path
        //    string filePath = Path.Combine(_webHostEnvironment.ContentRootPath, "Files/Test.txt");
        //    string fileType = "Application/txt";
        //    string fileName = "File.txt";
        //    return PhysicalFile(filePath, fileType, fileName);
        //}

        ////Byte array response
        //public FileResult Index()
        //{
        //    string filePath = Path.Combine(_webHostEnvironment.ContentRootPath, "Files/Test.txt");
        //    byte[] mas = System.IO.File.ReadAllBytes(filePath);
        //    string fileType = "Application/txt";
        //    string fileName = "File.txt";
        //    return File(mas, fileType, fileName);
        //}

        //File stream
        public FileResult Index()
        {
            string path = Path.Combine(_webHostEnvironment.ContentRootPath, "Files/Test.txt");
            FileStream fs = new FileStream(path, FileMode.Open);
            string fileType = "Application/txt";
            string fileName = "File.txt";
            return File(fs, fileType, fileName);
        }
    }
}
