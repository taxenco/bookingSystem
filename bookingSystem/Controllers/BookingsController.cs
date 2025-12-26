using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using bookingSystem.Data;
using bookingSystem.Models;

namespace bookingSystem.Controllers
{
    [Authorize(Roles = "admin")]
    public class BookingsController : Controller
    {
        private readonly AppDbContext _context;

        public BookingsController(AppDbContext context)
        {
            _context = context;
        }

        // =========================
        // GET: /Bookings/Create
        // =========================
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Bookings
            {
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(1)
            });
        }

        // =========================
        // POST: /Bookings/Create
        // =========================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Bookings booking)
        {
            if (booking.EndDate <= booking.StartDate)
            {
                ModelState.AddModelError("EndDate", "End date must be after start date");
            }

            if (!ModelState.IsValid)
                return View(booking);

            booking.CreatedAt = DateTime.UtcNow;

            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Dashboard");
        }

        // =========================
        // GET: /Bookings/Edit/5
        // =========================
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);

            if (booking == null)
                return NotFound();

            return View(booking);
        }

        // =========================
        // POST: /Bookings/Edit
        // =========================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Bookings booking)
        {
            if (booking.EndDate <= booking.StartDate)
            {
                ModelState.AddModelError("EndDate", "End date must be after start date");
            }

            if (!ModelState.IsValid)
                return View(booking);

            _context.Bookings.Update(booking);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Dashboard");
        }
    }
}
