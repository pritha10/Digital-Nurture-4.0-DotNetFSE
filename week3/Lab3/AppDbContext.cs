using Microsoft.EntityFrameworkCore;
using Lab3.Models;

namespace Lab3
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=RetailLab3Db;Trusted_Connection=True;");
        }
    }
}
