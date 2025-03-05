using InternetShop.Models;
using Microsoft.EntityFrameworkCore;

namespace InternetShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                    new Category { Id = 1, Name = "Action", OrderDisplay = 1 },
                    new Category { Id = 2, Name = "Horror", OrderDisplay = 2 },
                    new Category { Id = 3, Name = "Romantic", OrderDisplay = 3 }
                );
        }

        public DbSet<Category> Categories { get; set; }
    }
}
