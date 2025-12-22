using bookingSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace bookingSystem.Data.Seedings
{
    public static class UserSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var users = new List<Users>();
            var random = new Random(42);
            var hasher = new PasswordHasher<Users>();

            for (int i = 1; i <= 10; i++)
            {
                var role = random.Next(0, 5) == 0 ? "admin" : "user";

                var user = new Users
                {
                    Id = i,
                    Email = $"user{i}@booking.com",
                    Role = role,
                    CreatedAt = DateTime.UtcNow,
                    PasswordHash = "" 
                };

            
                user = new Users
                {
                    Id = user.Id,
                    Email = user.Email,
                    Role = user.Role,
                    CreatedAt = user.CreatedAt,
                    PasswordHash = hasher.HashPassword(user, "123456")
                };

                users.Add(user);
            }

            modelBuilder.Entity<Users>().HasData(users);
        }
    }
}
