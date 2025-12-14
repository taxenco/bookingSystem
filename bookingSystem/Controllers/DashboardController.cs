using bookingSystem.Data;
using bookingSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;

public class DashboardController : Controller
{
    private readonly AppDbContext _context;

    public DashboardController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var today = DateTime.UtcNow.Date;

        var vm = new DashboardViewModel
        {
            TotalUsers = _context.Users.Count(),
            TotalResources = _context.Resources.Count(),
            ActiveResources = _context.Resources.Count(r => r.IsActive),

            TotalBookings = _context.Bookings.Count(),
            BookingsToday = _context.Bookings.Count(b => b.StartDate.Date == today),

            BookingsByStatus = _context.Bookings
                .GroupBy(b => b.Status)
                .ToDictionary(g => g.Key.ToString(), g => g.Count()),

            LatestBookings = _context.Bookings
                .OrderByDescending(b => b.CreatedAt)
                .Take(5)
                .ToList()
        };

        return View(vm);
    }
}
