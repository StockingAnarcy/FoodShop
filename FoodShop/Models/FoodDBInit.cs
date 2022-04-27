/*using System.Data.Entity;


namespace FoodShop.Models
{
    public class FoodDbInit 
    {
        public static void Initialize(FoodContext context)
        {
            if (!context.Foods.Any())
            {
                context.Foods.AddRange(
                    new Food
                    {
                        Name = "Cocиска в тесте",
                        Count = 64,
                        Price = 89
                    },
                    new Food
                    {
                        Name = "Бургер",
                        Count = 34,
                        Price = 269
                    },
                     new Food
                     {
                         Name = "Салат Цезарь",
                         Count = 37,
                         Price = 159
                     },
                    new Food
                    {
                        Name = "Креветки",
                        Count = 37,
                        Price = 99
                    },
                    new Food
                    {
                        Name = "Чай",
                        Count = 28,
                        Price = 16
                    },
                    new Food
                    {
                        Name = "Кола",
                        Count = 54,
                        Price = 120
                    },
                    new Food
                    {
                        Name = "Сок",
                        Count = 29,
                        Price = 67
                    });
                context.SaveChanges();
            }

        }
    }
}*/