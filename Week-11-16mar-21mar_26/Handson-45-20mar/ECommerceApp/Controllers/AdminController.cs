using Microsoft.AspNetCore.Mvc;
using ECommerceApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ECommerceApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Dashboard()
        {
            // ✅ Basic Counts
            ViewBag.TotalProducts = _context.Products.Count();
            ViewBag.TotalOrders = _context.Orders.Count();
            ViewBag.TotalCustomers = _context.Customers.Count();

            // ✅ Pending Orders (Bonus Feature)
            ViewBag.PendingOrders = _context.ShippingDetails
                .Where(s => s.Status == "Pending")
                .Count();

            // ✅ Latest Orders (for display)
            var latestOrders = _context.Orders
                .Include(o => o.Customer)
                .OrderByDescending(o => o.OrderDate)
                .Take(5)
                .ToList();

            return View(latestOrders); // passing data to view
        }
    }
}