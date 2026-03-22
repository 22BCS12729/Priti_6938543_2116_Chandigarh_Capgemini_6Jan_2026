using Microsoft.AspNetCore.Mvc;
using SessionLoginDBApp.Data;
using SessionLoginDBApp.Models;

namespace SessionLoginDBApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = _context.Users
                .FirstOrDefault(x => x.Username == username && x.Password == password);

            if (user != null)
            {
                HttpContext.Session.SetString("username", username);

                return RedirectToAction("Dashboard");
            }

            ViewBag.Error = "Invalid Login";

            return View();
        }

        public IActionResult Dashboard()
        {
            var user = HttpContext.Session.GetString("username");

            if (user == null)
            {
                return RedirectToAction("Login");
            }

            ViewBag.User = user;

            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Login");
        }
    }
}