
using Microsoft.EntityFrameworkCore;

namespace MySavings.Data
{
    public class MySavingsDbContext : DbContext
    {
        // public DbSet<User> Users { get; set; }
        
        public MySavingsDbContext(DbContextOptions<MySavingsDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}