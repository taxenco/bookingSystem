using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using bookingSystem.Models;

namespace bookingSystem.Controllers
{
    // ---------------------------------------------------------------------
    // HomeController
    //
    // Acts as a protected entry point for authenticated users.
    // All actions in this controller require a valid authenticated session.
    //
    // Unauthenticated access is automatically redirected to the login page
    // by the authentication middleware.
    // ---------------------------------------------------------------------
    [Authorize]
    public class HomeController : BaseController
    {
        // -----------------------------------------------------------------
        // Index
        //
        // Default home page for authenticated users.
        // Typically used as a landing or redirect point after login.
        // -----------------------------------------------------------------
        public IActionResult Index()
        {
            return View();
        }

        // -----------------------------------------------------------------
        // Privacy
        //
        // Displays application privacy information.
        // Access restricted to authenticated users.
        // -----------------------------------------------------------------
        public IActionResult Privacy()
        {
            return View();
        }

        // -----------------------------------------------------------------
        // Error
        //
        // Displays application error information.
        // This action is intentionally protected to avoid exposing internal
        // details to unauthenticated users.
        //
        // Response caching is disabled to prevent stale or sensitive data
        // from being stored by clients or proxies.
        // -----------------------------------------------------------------
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(
                new ErrorViewModel
                {
                    RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
                }
            );
        }
    }
}
