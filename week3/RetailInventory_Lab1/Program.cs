using RetailInventory;
using RetailInventory.Models;

using (var context = new InventoryContext())
{
    
    if (!context.Products.Any())
    {
        var product = new Product
        {
            Name = "Wireless Mouse",
            Category = "Electronics",
            StockQuantity = 25
        };

        context.Products.Add(product);
        context.SaveChanges();

        Console.WriteLine("Product added successfully!");
    }
    var products = context.Products.ToList();

    Console.WriteLine("Product List:");
    foreach (var p in products)
    {
        Console.WriteLine($"ID: {p.ProductId}, Name: {p.Name}, Category: {p.Category}, Stock: {p.StockQuantity}");
    }
}

