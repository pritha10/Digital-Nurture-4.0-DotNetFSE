using System;
using System.Linq;
using System.Threading.Tasks;
using Lab3.Models;

namespace Lab3
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            
            Console.WriteLine("🔁 Starting app...");

            using var context = new AppDbContext();

            if (!context.Categories.Any())
            {
                var electronics = new Category { Name = "Electronics" };
                var groceries = new Category { Name = "Groceries" };

                await context.Categories.AddRangeAsync(electronics, groceries);

                var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
                var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

                await context.Products.AddRangeAsync(product1, product2);

                await context.SaveChangesAsync();
                Console.WriteLine("✅ Data inserted successfully.");
            }
            else
            {
                Console.WriteLine("ℹ️ Data already exists in the database.");
            }
        }
    }
}


