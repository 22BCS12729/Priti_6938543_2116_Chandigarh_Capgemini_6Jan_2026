using Microsoft.AspNetCore.Mvc;
using StudentApp.Data;
using StudentApp.Models;
using System.Linq;

public class StudentController : Controller
{
    private readonly ApplicationDbContext _context;

    public StudentController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Students.ToList());
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Student student)
    {
        if (ModelState.IsValid)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(student);
    }

    // EDIT MODAL
    public IActionResult Edit(int id)
    {
        var student = _context.Students.Find(id);
        return PartialView("_EditModal", student);
    }

    [HttpPost]
    public IActionResult Edit(Student student)
    {
        _context.Students.Update(student);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    // DELETE
    [HttpPost]
    public IActionResult Delete(int id)
    {
        var student = _context.Students.Find(id);
        if (student != null)
        {
            _context.Students.Remove(student);
            _context.SaveChanges();
        }
        return RedirectToAction("Index");
    }
}