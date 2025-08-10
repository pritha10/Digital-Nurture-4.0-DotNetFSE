using System;
using System.Linq;
using RetailInventory1.Models;

namespace RetailInventory1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                // Seed only if the database is empty
                if (!context.Categories.Any())
                {
                    var electronics = new Category { Name = "Electronics" };
                    var groceries = new Category { Name = "Groceries" };

                    context.Categories.AddRange(electronics, groceries);

                    context.Products.AddRange(
                        new Product { Name = "Laptop", Price = 50000, Category = electronics },
                        new Product { Name = "Smartphone", Price = 20000, Category = electronics },
                        new Product { Name = "Apple", Price = 50, Category = groceries }
                    );

                    context.SaveChanges();
                }

                // Display all products
                var products = context.Products
                    .Select(p => new
                    {
                        p.Name,
                        p.Price,
                        CategoryName = p.Category.Name
                    })
                    .ToList();

                Console.WriteLine("📦 Products in Inventory:\n");

                foreach (var product in products)
                {
                    Console.WriteLine($"- {product.Name} ({product.CategoryName}) - ₹{product.Price}");
                }
            }
        }
    }
}
    
