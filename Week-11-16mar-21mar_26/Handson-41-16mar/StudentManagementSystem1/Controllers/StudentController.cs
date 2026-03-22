using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models;

public class StudentController : Controller
{
    private readonly AppDbContext _context;

    public StudentController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(Student s)
    {
        if (ModelState.IsValid)
        {
            _context.Students.Add(s);
            _context.SaveChanges();

            TempData["msg"] = "Student Added!";
            return RedirectToAction("List");
        }

        return View(s);
    }

    public IActionResult List()
    {
        return View(_context.Students.ToList());
    }
}