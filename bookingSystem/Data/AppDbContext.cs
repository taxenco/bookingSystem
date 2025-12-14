using Microsoft.EntityFrameworkCore;
using bookingSystem.Models;
using bookingSystem.Data.Seedings;

namespace bookingSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Resources> Resources { get; set; }
        public DbSet<Bookings> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            UserSeed.Seed(modelBuilder);
            ResourceSeed.Seed(modelBuilder);
            BookingSeed.Seed(modelBuilder);
        }
    }
}
