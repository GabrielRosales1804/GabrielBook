using Microsoft.EntityFrameworkCore;

namespace GabrielBookWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
        public DbSet<Models.Category> Categories { get; set; }
    }
}
