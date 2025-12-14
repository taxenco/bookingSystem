using bookingSystem.Models;


namespace bookingSystem.ViewModels
{
    public class DashboardViewModel
    {
        public int TotalUsers { get; set; }
        public int TotalResources { get; set; }
        public int ActiveResources { get; set; }

        public int TotalBookings { get; set; }
        public int BookingsToday { get; set; }

        public Dictionary<string, int> BookingsByStatus { get; set; } = new();

        public List<Bookings> LatestBookings { get; set; } = new();
    }
}
