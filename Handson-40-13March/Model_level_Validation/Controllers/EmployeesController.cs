using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Model_level_Validation.Data;
using Model_level_Validation.Models;

namespace Model_level_Validation.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly AppDbContext _context;

        public EmployeesController(AppDbContext context)
        {
            _context = context;
        }

        // Show employees
        public IActionResult Index()
        {
            var employees = _context.Employees
                .Include(e => e.Company)
                .ToList();

            return View(employees);
        }

        // Open Add Employee page
        public IActionResult Create()
        {
            ViewBag.Companies = new SelectList(_context.Companies, "Id", "Name");
            return View();
        }

        // Save employee
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(emp);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Companies = new SelectList(_context.Companies, "Id", "Name");
            return View(emp);
        }

        // Delete employee
        public IActionResult Delete(int id)
        {
            var emp = _context.Employees.Find(id);

            if (emp != null)
            {
                _context.Employees.Remove(emp);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}