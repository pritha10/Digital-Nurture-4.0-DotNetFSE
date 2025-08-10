using Microsoft.EntityFrameworkCore;

using StoreAppLab4.Models; // Make sure this matches your folder structure

namespace StoreAppLab4.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Product> Products => Set<Product>();
    }
}
