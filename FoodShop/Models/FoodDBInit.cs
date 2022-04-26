using MySql.Data.MySqlClient;
using System.Data.Entity;
using System.Data.SqlClient;

namespace FoodShop.Models
{
    public class FoodDbInit : DropCreateDatabaseAlways<FoodContext>
    {
       
        protected override void Seed(FoodContext db)
        {    
            db.Foods.Add(new Food
            {
                Name = "Cocиска в тесте",
                Count = 64,
                Price = 89
            });
            db.Foods.Add(new Food
            {
                Name = "Бургер",
                Count = 34,
                Price = 269
            });
            db.Foods.Add(new Food
            {
                Name = "Салат Цезарь",
                Count = 37,
                Price = 159
            });
            db.Foods.Add(new Food
            {
                Name = "Креветки",
                Count = 37,
                Price = 99
            });
            db.Foods.Add(new Food
            {
                Name = "Чай",
                Count = 28,
                Price = 16
            });
            db.Foods.Add(new Food
            {
                Name = "Кола",
                Count = 54,
                Price = 120
            });
            db.Foods.Add(new Food
            {
                Name = "Сок",
                Count = 29,
                Price = 67
            });
            base.Seed(db);
        }

    }
}