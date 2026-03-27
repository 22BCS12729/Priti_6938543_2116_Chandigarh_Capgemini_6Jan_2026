using Microsoft.AspNetCore.Mvc;
using ProductApp.Services;

namespace ProductApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }

        public IActionResult List()
        {
            var products = _service.GetProducts();
            return View(products);
        }
    }
}