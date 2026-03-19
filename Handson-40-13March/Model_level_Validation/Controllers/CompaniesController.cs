using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model_level_Validation.Data;
using Model_level_Validation.Models;

namespace Model_level_Validation.Controllers
{
    public class CompaniesController : Controller
    {
        private readonly AppDbContext _context;

        public CompaniesController(AppDbContext context)
        {
            _context = context;
        }

        // SHOW ALL COMPANIES
        public IActionResult Index()
        {
            var companies = _context.Companies
                .Include(c => c.Employees)
                .ToList();

            return View(companies);
        }

        // OPEN CREATE PAGE
        public IActionResult Create()
        {
            return View();
        }

        // SAVE COMPANY
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Company company)
        {
            if (ModelState.IsValid)
            {
                _context.Companies.Add(company);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(company);
        }

        // DELETE COMPANY
        public IActionResult Delete(int id)
        {
            var company = _context.Companies.FirstOrDefault(c => c.Id == id);

            if (company != null)
            {
                _context.Companies.Remove(company);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}