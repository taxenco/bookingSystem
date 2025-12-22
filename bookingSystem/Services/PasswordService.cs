using Microsoft.AspNetCore.Identity;

namespace bookingSystem.Services
{
    public class PasswordService
    {
        private readonly PasswordHasher<string> _hasher = new();

        public string Hash(string password)
        {
            return _hasher.HashPassword("", password);
        }

        public bool Verify(string hashedPassword, string inputPassword)
        {
            var result = _hasher.VerifyHashedPassword("", hashedPassword, inputPassword);
            return result == PasswordVerificationResult.Success;
        }
    }
}
