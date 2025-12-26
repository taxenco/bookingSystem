using System;
using System.Linq;
using System.Threading.Tasks;
using bookingSystem.Data;
using bookingSystem.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bookingSystem.Controllers
{
    // ---------------------------------------------------------------------
    // DashboardController
    //
    // Responsible for serving the main dashboard of the application.
    // Provides aggregated, read-only metrics related to users, resources,
    // and bookings.
    //
    // Access is restricted to authenticated users.
    // ---------------------------------------------------------------------
    [Authorize]
    public class DashboardController : Controller   
    {
        // Entity Framework database context.
        // Used exclusively for read operations in this controller.
        private readonly AppDbContext _context;

        // -----------------------------------------------------------------
        // Constructor
        //
        // Receives the application database context via dependency injection.
        // -----------------------------------------------------------------
        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        // -----------------------------------------------------------------
        // Index
        //
        // Main dashboard endpoint.
        //
        // Collects and aggregates high-level system statistics including:
        // - total users
        // - resource availability
        // - booking activity
        //
        // All values are calculated using UTC time to avoid timezone drift.
        //
        // Returns:
        // - HTTP 200 response with populated DashboardViewModel
        // -----------------------------------------------------------------
        public async Task<IActionResult> Index()
        {
            // UTC date boundaries for "today"
            var today = DateTime.UtcNow.Date;
            var tomorrow = today.AddDays(1);

            // Assemble dashboard metrics
            var vm = new DashboardViewModel
            {
                // Total registered users
                TotalUsers = await _context.Users.CountAsync(),

                // Total resources in the system
                TotalResources = await _context.Resources.CountAsync(),

                // Resources currently marked as active
                ActiveResources = await _context.Resources.CountAsync(r => r.IsActive),

                // Total number of bookings
                TotalBookings = await _context.Bookings.CountAsync(),

                // Bookings starting today (UTC)
                BookingsToday = await _context.Bookings.CountAsync(b =>
                    b.StartDate >= today && b.StartDate < tomorrow
                ),

                // Booking count grouped by status
                BookingsByStatus = await _context.Bookings
                    .GroupBy(b => b.Status)
                    .Select(g => new
                    {
                        Status = g.Key != null ? g.Key.ToString() : "Unknown",
                        Count = g.Count()
                    })
                    .ToDictionaryAsync(x => x.Status, x => x.Count),

                // Most recent bookings ordered by creation date
                LatestBookings = await _context.Bookings
                    .OrderByDescending(b => b.CreatedAt)
                    .Take(5)
                    .ToListAsync()
            };

            // Render dashboard view
            return View(vm);
        }
    }
}
