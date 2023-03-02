using Microsoft.EntityFrameworkCore;
using VehicleRental.Models;

namespace VehicleRental
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Product>? Products { get; set; }


        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product[] {
                new Product {ID = 1, ProductName = "Samsung Galaxy s23 Ultra", ProductType = ProductType.Smartphone, Price = 2000.00m},
                new Product {ID = 2, ProductName = "Samsung Galaxy s23 Plus", ProductType = ProductType.Smartphone, Price = 1700.00m},
                new Product {ID = 3, ProductName = "Samsung Galaxy s23 ", ProductType = ProductType.Smartphone, Price = 1200.00m},
                new Product {ID = 4, ProductName = "Nvidia Geforce GTX4090", ProductType = ProductType.GraphicCard, Price = 3500.00m},
            });
        }
    }
}