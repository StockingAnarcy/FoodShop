using System;
using System.Linq;
using System.Data.Entity;


namespace FoodShop.Models
{
    public class FoodContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}
