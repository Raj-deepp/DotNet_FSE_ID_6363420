using Microsoft.EntityFrameworkCore;
using RetailInventory.Models;

namespace RetailInventory.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=localhost\SQLEXPRESS;Database=RetailInventoryDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }


        //LAB 9 -> SEEDING DATA DURING MIGRATIONS

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 100, Name = "Electronics" },
                new Category { Id = 200, Name = "Groceries" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 101,
                    Name = "Smartphone",
                    Price = 25000,
                    CategoryId = 100,
                    StockQuantity = 50
                },
                new Product
                {
                    Id = 201,
                    Name = "Wheat Flour",
                    Price = 800,
                    CategoryId = 200,
                    StockQuantity = 100
                }
            );
        }
    }
}
