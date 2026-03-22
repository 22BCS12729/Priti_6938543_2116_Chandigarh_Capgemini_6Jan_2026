using Microsoft.AspNetCore.Mvc;
using JwtMvcDemo.Models;
using JwtMvcDemo.Data;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace JwtMvcDemo.Controllers
{
    public class AccountController : Controller
    {
        private readonly IConfiguration _config;

        public AccountController(IConfiguration config)
        {
            _config = config;
        }

        // ---------------- REGISTER ----------------
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
            {
                ViewBag.Message = "Please fill all fields!";
                return View();
            }

            // Check if user already exists
            var existingUser = UserStore.Users
                .FirstOrDefault(u => u.Username == user.Username);

            if (existingUser != null)
            {
                ViewBag.Message = "User already exists!";
                return View();
            }

            // Save user
            UserStore.Users.Add(user);

            // ✅ Redirect to login with success message
            TempData["Success"] = "Registration Successful! Please Login.";

            return RedirectToAction("Login");
        }

        // ---------------- LOGIN ----------------
        public IActionResult Login()
        {
            // Show success message after register
            ViewBag.Success = TempData["Success"];
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            if (string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
            {
                ViewBag.Message = "Please enter username and password!";
                return View();
            }

            var validUser = UserStore.Users
                .FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password);

            if (validUser != null)
            {
                // ✅ Generate token
                var token = GenerateToken(validUser);

                // ✅ Store in session
                HttpContext.Session.SetString("JWToken", token);
                HttpContext.Session.SetString("Username", validUser.Username);

                // ✅ Redirect to dashboard
                return RedirectToAction("Dashboard");
            }

            ViewBag.Message = "Invalid Login!";
            return View();
        }

        // ---------------- DASHBOARD ----------------
        public IActionResult Dashboard()
        {
            var token = HttpContext.Session.GetString("JWToken");

            if (string.IsNullOrEmpty(token))
            {
                return RedirectToAction("Login");
            }

            // ✅ Pass username to view
            ViewBag.Username = HttpContext.Session.GetString("Username");

            return View();
        }

        // ---------------- LOGOUT ----------------
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        // ---------------- JWT TOKEN ----------------
        private string GenerateToken(User user)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.Username)
            };

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_config["Jwt:Key"]));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}