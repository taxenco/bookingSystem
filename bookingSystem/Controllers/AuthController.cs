using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace bookingSystem.Controllers
{
    [AllowAnonymous]
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Login(string? returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }
    }
}
