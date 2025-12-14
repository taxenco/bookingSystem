using System.ComponentModel.DataAnnotations;

namespace bookingSystem.Models
{
    public class Users
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [MinLength(8)]
        public required string PasswordHash { get; set; }

        [Required]
        [RegularExpression("^(user|admin)$", ErrorMessage = "Role must be either 'user' or 'admin'")]
        public required string Role { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    }
}
