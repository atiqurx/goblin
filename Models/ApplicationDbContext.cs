using Microsoft.EntityFrameworkCore;

namespace goblin.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Transaction> Transactions { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

    }
}