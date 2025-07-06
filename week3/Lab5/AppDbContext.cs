using Microsoft.EntityFrameworkCore;
using Lab5.Models;

namespace Lab5;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories => Set<Category>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=RetailLab5Db;Trusted_Connection=True;");
    }
}
