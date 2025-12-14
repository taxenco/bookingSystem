using System.ComponentModel.DataAnnotations;

namespace bookingSystem.Models
{
    public class Resources
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public required string Name { get; set; }

        [Required]
        public required string Description { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    }
}
