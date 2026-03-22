using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models;

public class ProductController : Controller
{
    private readonly AppDbContext _context;

    public ProductController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Products.ToList());
    }

    public IActionResult Create() => View();

    [HttpPost]
    public IActionResult Create(Product p)
    {
        _context.Products.Add(p);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}