using bookingSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace bookingSystem.Data.Seedings
{
    public static class BookingSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var bookings = new List<Bookings>();
            var random = new Random(123); // seed fija para EF

            var statuses = new[]
            {
                "Requested",
                "Confirmed",
                "Rejected",
                "Cancelled",
                "Rescheduled",
                "InProgress",
                "Completed",
                "NoShow",
                "Expired"
            };

            for (int i = 1; i <= 10; i++)
            {
                var startDate = DateTime.UtcNow.AddDays(random.Next(-10, 10));
                var endDate = startDate.AddDays(random.Next(1, 5));

                bookings.Add(new Bookings
                {
                    Id = i,
                    UserId = random.Next(1, 11),     // Users Ids 1–10
                    ResourceId = random.Next(1, 11), // Resources Ids 1–10
                    StartDate = startDate,
                    EndDate = endDate,
                    Status = statuses[random.Next(statuses.Length)],
                    CreatedAt = DateTime.UtcNow
                });
            }

            modelBuilder.Entity<Bookings>().HasData(bookings);
        }
    }
}
