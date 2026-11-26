using GabrielBook.Models;
using Microsoft.EntityFrameworkCore;

namespace GabrielBookWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Fiction",
                    DisplayOrder = 1
                },
                new Category
                {
                    Id = 2,
                    Name = "Action",
                    DisplayOrder = 2
                },
                new Category
                {
                    Id = 3,
                    Name = "Sci-Fi",
                    DisplayOrder = 3
                }
            );
        }
    }
}
