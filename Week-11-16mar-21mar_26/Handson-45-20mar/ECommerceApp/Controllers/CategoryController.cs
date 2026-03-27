using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ECommerceApp.Data;
using ECommerceApp.Models;

namespace ECommerceApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ✅ SHOW CATEGORY LIST
        public async Task<IActionResult> Index()
        {
            var categories = await _context.Categories.ToListAsync();
            return View(categories);
        }

        // ✅ CREATE GET
        public IActionResult Create()
        {
            return View();
        }

        // ✅ CREATE POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(category); // more clear
                await _context.SaveChangesAsync();

                // ✅ redirect to list after save
                return RedirectToAction("Index");
            }

            // ❌ if validation fails → stay on same page
            return View(category);
        }
    }
}