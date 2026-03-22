using Microsoft.AspNetCore.Mvc;
using ProductManagementApp.Filters;
using ProductManagementApp.Models;

namespace ProductManagementApp.Controllers
{
    [ServiceFilter(typeof(LogActionFilter))]
    public class ProductController : Controller
    {
        static List<Product> products = new List<Product>()
        {
            new Product { Id = 1, Name = "Laptop", Price = 80000 },
            new Product { Id = 2, Name = "Mobile", Price = 30000 }
        };

        public IActionResult Index()
        {
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                product.Id = products.Count + 1;
                products.Add(product);

                TempData["msg"] = "Product Added Successfully";

                return RedirectToAction("Index");
            }

            return View(product);
        }

        public IActionResult Details(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return NotFound();

            return View(product);
        }
    }
}