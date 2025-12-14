using System.ComponentModel.DataAnnotations;

namespace bookingSystem.Models
{
    public class Bookings
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int ResourceId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        [RegularExpression(
            "^(Requested|Confirmed|Rejected|Cancelled|Rescheduled|InProgress|Completed|NoShow|Expired)$",
            ErrorMessage = "Invalid booking status"
        )]
        public string Status { get; set; } = "Requested";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
