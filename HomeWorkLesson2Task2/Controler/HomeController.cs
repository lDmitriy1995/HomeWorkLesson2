using HomeWorkLesson2Task2.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeWorkLesson2Task2.Controler
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
     
        }
        public IActionResult GetProduct() 
        {
            Products products = new Products(1, "My stoboi eli", 1250) { PathImage = "" };
            return View();
        }

    }

}
