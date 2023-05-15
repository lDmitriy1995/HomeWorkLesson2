using HomeWorkLesson2.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeWorkLesson2.Controlers
{
    public class CompanyController : Controller
    {
        List<Products> products = new List<Products>();

        public CompanyController() 
        {
            products.Add(new Products(1, "My stoboi eli", 1250) {PathImage="" });
            products.Add(new Products(2, "Lepeshka", 1350) { PathImage = "9b8f63ff3c2c96a2b90d326871027738.jpg" });
            products.Add(new Products(3, "Maionez", 1280) { PathImage = "загруженное.jpg" });
            products.Add(new Products(3, "A pootom pili", 1700) { PathImage = "" });
            products.Add(new Products(4, "Gramotnyi", 1650) { PathImage = "" });
            products.Add(new Products(5, "Dushes", 450) { PathImage = "загруженное (1).jpg" });
            
        }


        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Products() 
        {

            return View(products);
        }

        public IActionResult Images() 
        {
            
            return View(products.Where(w=>w.Price>1500).ToList());
        }
    }
}
