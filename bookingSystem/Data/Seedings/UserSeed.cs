using bookingSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace bookingSystem.Data.Seedings
{
    public static class UserSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var users = new List<Users>();
            var random = new Random(42); // seed fija para EF

            for (int i = 1; i <= 10; i++)
            {
                var isAdmin = random.Next(0, 5) == 0; // ~20% admins

                users.Add(new Users
                {
                    Id = i,
                    Email = $"user{i}@booking.com",
                    PasswordHash = $"hashed_password_{i}",
                    Role = isAdmin ? "admin" : "user",
                    CreatedAt = DateTime.UtcNow
                });
            }

            modelBuilder.Entity<Users>().HasData(users);
        }
    }
}
