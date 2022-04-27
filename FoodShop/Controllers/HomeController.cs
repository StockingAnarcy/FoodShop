using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using FoodShop.Models;

namespace FoodShop.Controllers
{
    public class HomeController : Controller
    {

        FoodContext db;
        public HomeController(FoodContext context)
        {
            db = context;
        }
        
        public async Task<IActionResult> Index()
        {

            return View(await db.Foods.ToListAsync());
        }

        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null) return RedirectToAction("Index");

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

    } 
}