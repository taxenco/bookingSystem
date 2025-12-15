using bookingSystem.Data;
using bookingSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bookingSystem.Controllers
{
    public class DashboardController : BaseController
    {
        private readonly AppDbContext _context;

        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var today = DateTime.UtcNow.Date;
            var tomorrow = today.AddDays(1);

            var vm = new DashboardViewModel
            {
                TotalUsers = _context.Users.Count(),

                TotalResources = _context.Resources.Count(),
                ActiveResources = _context.Resources.Count(r => r.IsActive),

                TotalBookings = _context.Bookings.Count(),

                BookingsToday = _context.Bookings.Count(b =>
                    b.StartDate >= today && b.StartDate < tomorrow
                ),

                BookingsByStatus = _context.Bookings
                    .GroupBy(b => b.Status)
                    .Select(g => new
                    {
                        Status = g.Key.ToString(),
                        Count = g.Count()
                    })
                    .ToDictionary(x => x.Status, x => x.Count),

                LatestBookings = _context.Bookings
                    .OrderByDescending(b => b.CreatedAt)
                    .Take(5)
                    .ToList()
            };

            return View(vm);
        }
    }
}
