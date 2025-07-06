using Microsoft.EntityFrameworkCore;
using RetailInventory.Models;

namespace RetailInventory.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(
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

            // Lab 11: Configure One-to-One Product <-> ProductDetail
            modelBuilder.Entity<Product>()
                .HasOne(p => p.ProductDetail)
                .WithOne(pd => pd.Product)
                .HasForeignKey<ProductDetail>(pd => pd.ProductId);
        }
    }
}
