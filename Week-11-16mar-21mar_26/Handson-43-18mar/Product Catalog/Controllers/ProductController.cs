using Microsoft.AspNetCore.Mvc;
using StudentApp.Data;
using StudentApp.Models;
using System.Linq;

public class ProductController : Controller
{
    private readonly ApplicationDbContext _context;

    public ProductController(ApplicationDbContext context)
    {
        _context = context;
    }

    // 🔍 LIST + SEARCH
    public IActionResult Index(string search)
    {
        var products = _context.Products.AsQueryable();

        if (!string.IsNullOrEmpty(search))
        {
            products = products.Where(p => p.Name.Contains(search));
        }

        return View(products.ToList());
    }

    // 📄 DETAILS PAGE
    public IActionResult Details(int id)
    {
        var product = _context.Products.FirstOrDefault(p => p.Id == id);

        if (product == null)
        {
            return NotFound();
        }

        return View(product);
    }

    // ➕ CREATE (GET)
    public IActionResult Create()
    {
        return View();
    }

    // ➕ CREATE (POST)
    [HttpPost]
    public IActionResult Create(Product product)
    {
        if (ModelState.IsValid)
        {
            _context.Products.Add(product);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        return View(product);
    }

    // 🗑️ DELETE (NEW)
    public IActionResult Delete(int id)
    {
        var product = _context.Products.Find(id);

        if (product != null)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        return RedirectToAction("Index");
    }
}