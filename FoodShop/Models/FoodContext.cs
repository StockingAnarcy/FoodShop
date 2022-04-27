using Microsoft.EntityFrameworkCore;

namespace FoodShop.Models
{
    public class FoodContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

        public FoodContext(DbContextOptions<FoodContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }

}