using System;
using System.Linq;
using System.Threading.Tasks;
using bookingSystem.Data;
using bookingSystem.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;


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
            var isAdmin = User.IsInRole("admin");
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

            ViewBag.Email = User.FindFirstValue(ClaimTypes.Email);
            ViewBag.IsAdmin = isAdmin;

            var today = DateTime.UtcNow.Date;
            var tomorrow = today.AddDays(1);

            var bookingsQuery = _context.Bookings.AsQueryable();

            // 🔐 Usuario normal: solo sus bookings
            if (!isAdmin)
            {
                bookingsQuery = bookingsQuery.Where(b => b.UserId == userId);
            }

            var vm = new DashboardViewModel
            {
                // SOLO admin ve métricas globales
                TotalUsers = isAdmin ? await _context.Users.CountAsync() : 0,
                TotalResources = isAdmin ? await _context.Resources.CountAsync() : 0,
                ActiveResources = isAdmin ? await _context.Resources.CountAsync(r => r.IsActive) : 0,

                TotalBookings = await bookingsQuery.CountAsync(),

                BookingsToday = await bookingsQuery.CountAsync(b =>
                    b.StartDate >= today && b.StartDate < tomorrow
                ),

                BookingsByStatus = await bookingsQuery
                    .GroupBy(b => b.Status)
                    .Select(g => new
                    {
                        Status = g.Key != null ? g.Key.ToString() : "Unknown",
                        Count = g.Count()
                    })
                    .ToDictionaryAsync(x => x.Status, x => x.Count),

                LatestBookings = await bookingsQuery
                    .OrderByDescending(b => b.CreatedAt)
                    .Take(5)
                    .ToListAsync()
            };

            return View(vm);
        }
    }
}
