using Microsoft.EntityFrameworkCore;

namespace GabrielBookWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
        public DbSet<Models.Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Models.Category>().HasData(
                new Models.Category
                {
                    Id = 1,
                    Name = "Fiction"
                },
                new Models.Category
                {
                    Id = 2,
                    Name = "Action"
                },
                new Models.Category
                {
                    Id = 3,
                    Name = "Sci-Fi"
                }
            );
        }
    }
}
