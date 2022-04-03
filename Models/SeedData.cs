using CoffeeMug.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeMugWebAPI.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new Data.CoffeeMugWebAPIContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Data.CoffeeMugWebAPIContext>>());
            

            if (context.Product.Any())
            {
                return;   // DB has been seeded
            }

            context.Product.AddRange(
                new Product
                {
                    Name = "Smartphone",
                    Number = 10,
                    Quantity = 1,
                    Description = "samsung galaxy s10",
                    Price = 4000
                },

                new Product
                {
                    Name = "Laptop",
                    Number = 20,
                    Quantity = 2,
                    Description = "Dell ThinkPad",
                    Price = 6000
                },

                new Product
                {
                    Name = "Lamp",
                    Number = 30,
                    Quantity = 5,
                    Description = "generic standing lamp",
                    Price = 40
                },

                new Product
                {
                    Name = "Desk",
                    Number = 40,
                    Quantity = 1,
                    Description = "basic desk",
                    Price = 400
                }
            );
            context.SaveChanges();
        }
    }
}
