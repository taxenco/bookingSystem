using Microsoft.EntityFrameworkCore;
using bookingSystem.Models;

namespace bookingSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Resources> Resources { get; set; }
    }
}