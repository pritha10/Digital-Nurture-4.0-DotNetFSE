using Lab5;
using Microsoft.EntityFrameworkCore;
using Lab5.Models;

Console.WriteLine("🔍 Lab 5: Retrieving Data from the Database");

using var context = new AppDbContext();

// 1️⃣ Retrieve All Products
var products = await context.Products.ToListAsync();
Console.WriteLine("\n📦 All Products:");
foreach (var p in products)
{
    Console.WriteLine($"- {p.Name} - ₹{p.Price}");
}

// 2️⃣ Find by ID
var product = await context.Products.FindAsync(1);
Console.WriteLine($"\n🔍 Found by ID = 1: {product?.Name ?? "Not Found"}");

// 3️⃣ FirstOrDefault with Condition
var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
Console.WriteLine($"\n💰 Expensive: {expensive?.Name ?? "None"}");
