using Microsoft.EntityFrameworkCore;
using TestCoreApp.Models;

namespace TestCoreApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ):base(options)
        {

                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .Property(item => item.Price)
                .HasColumnType("decimal(18, 2)");
        }

        public DbSet<Item> Item { get; set; }
    }
}
