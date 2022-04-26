using FoodShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FoodShop.Controllers
{
    public class HomeController : Controller
    {
        

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        FoodContext db = new FoodContext();

        public IActionResult Index()
        {
           
            IEnumerable<Food> foods = db.Foods;
            
            ViewBag.Foods = foods;
           
            return View();
        }

        [HttpGet]
        public IActionResult Buy(int id)
        {
            ViewBag.FoodId = id;
            
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            
            db.Purchases.Add(purchase);
            
            db.SaveChanges();
            return "Спасибо за покупку, " + purchase.Person + "!";
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}