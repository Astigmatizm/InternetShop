using System.Net.Http.Headers;
using internetShop.Models;
using Microsoft.EntityFrameworkCore;
namespace InternetShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options) { Database.EnsureCreated(); }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                    new Category { Id = 1, Name = "Action", OrderDisplay = 1 },
                    new Category { Id = 2, Name = "Horror", OrderDisplay = 2 },
                    new Category { Id = 3, Name = "Romantic", OrderDisplay = 3 }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "C# in month",
                    Description = "Guide to C#",
                    Author = "Jon Skeet",
                    Price = 5999.99,
                    CategoryId = 1,
                },
                new Product
                {
                    Id = 2,
                    Title = "Clean Code",SEF
                    Price = 9999.99,
                    CategoryId = 2,
                }
            );
        }
            
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
