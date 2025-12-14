using bookingSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace bookingSystem.Data.Seedings
{
    public static class ResourceSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var resources = new List<Resources>();
            var random = new Random(99); // seed fija

            for (int i = 1; i <= 10; i++)
            {
                resources.Add(new Resources
                {
                    Id = i,
                    Name = $"Resource {i}",
                    Description = $"Auto generated resource number {i}",
                    IsActive = random.Next(0, 4) != 0, // ~75% activos
                    CreatedAt = DateTime.UtcNow
                });
            }

            modelBuilder.Entity<Resources>().HasData(resources);
        }
    }
}
