using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }
        public DbSet<LoginCredentials> LoginCredentials { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        
            // Categories seed data
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Phones" },
                new Category { Id = 2, Name = "TV" },
                new Category { Id = 3, Name = "Tablets" },
                new Category { Id = 4, Name = "Laptop" },
                new Category { Id = 5, Name = "Earphones" }
            );

            // Brands seed data
            modelBuilder.Entity<Brand>().HasData(
                new Brand { Id = 1, Name = "Samsung" },
                new Brand { Id = 2, Name = "Apple" },
                new Brand { Id = 3, Name = "OnePlus" }
            );

            // Products seed data
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Samsung Tablet",
                    Price = 30000,
                    CategoryId = 3,
                    BrandId = 1,
                    Quantity = 30,
                    ImgPath = "Prod1.jpg",
                    Description = "This is Samsung Tablet description."
                },
                new Product
                {
                    Id = 2,
                    Name = "iPad",
                    Price = 100000,
                    CategoryId = 3,
                    BrandId = 2,
                    Quantity = 10,
                    ImgPath = "Prod2.jpg",
                    Description = "This is iPad description."
                },
                new Product
                {
                    Id = 3,
                    Name = "Samsung TV",
                    Price = 80000,
                    CategoryId = 2,
                    BrandId = 1,
                    Quantity = 20,
                    ImgPath = "Prod3.jpg",
                    Description = "This is Samsung TV description."
                },
                new Product
                {
                    Id = 4,
                    Name = "Samsung M32",
                    Price = 20000,
                    CategoryId = 2,
                    BrandId = 1,
                    Quantity = 20,
                    ImgPath = "Prod4.jpg",
                    Description = "This is Samsung M32 description."
                },
                new Product
                {
                    Id = 5,
                    Name = "OnePlus 9",
                    Price = 45000,
                    CategoryId = 1,
                    BrandId = 3,
                    Quantity = 15,
                    ImgPath = "Prod5.jpg",
                    Description = "This is OnePlus 9 description."
                },
                new Product
                {
                    Id = 6,
                    Name = "Apple MacBook Pro",
                    Price = 150000,
                    CategoryId = 4,
                    BrandId = 2,
                    Quantity = 8,
                    ImgPath = "Prod6.jpg",
                    Description = "This is MacBook Pro description."
                },
                new Product
                {
                    Id = 7,
                    Name = "Samsung QLED 4K TV",
                    Price = 120000,
                    CategoryId = 2,
                    BrandId = 1,
                    Quantity = 12,
                    ImgPath = "Prod7.jpg",
                    Description = "This is Samsung QLED TV description."
                },
                new Product
                {
                    Id = 8,
                    Name = "iPad Pro",
                    Price = 120000,
                    CategoryId = 3,
                    BrandId = 2,
                    Quantity = 15,
                    ImgPath = "Prod8.jpg",
                    Description = "This is iPad Pro description."
                },
                new Product
                {
                    Id = 9,
                    Name = "OnePlus Buds",
                    Price = 8000,
                    CategoryId = 5,
                    BrandId = 3,
                    Quantity = 30,
                    ImgPath = "Prod9.jpg",
                    Description = "This is OnePlus Buds description."
                },
                new Product
                {
                    Id = 10,
                    Name = "Samsung Galaxy S21",
                    Price = 80000,
                    CategoryId = 1,
                    BrandId = 1,
                    Quantity = 25,
                    ImgPath = "Prod10.jpg",
                    Description = "This is Samsung Galaxy S21 description."
                }
            );
        }
    }
}
