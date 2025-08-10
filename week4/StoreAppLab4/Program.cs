using StoreAppLab4.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ✅ Add DB Context (update your connection string)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer("Server=localhost;Database=StoreDb;Trusted_Connection=True;TrustServerCertificate=True;"));

var app = builder.Build();

app.MapGet("/", () => "StoreApp is running!");
app.Run();
