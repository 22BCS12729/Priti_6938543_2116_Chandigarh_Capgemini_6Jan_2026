using Microsoft.AspNetCore.Mvc;
using System.Linq; // 👈 important

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
    private readonly AppDbContext _context;

    public CustomerController(AppDbContext context)
    {
        _context = context;
    }

    // ✅ GET all customers
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_context.Customers.ToList());
    }

    // ✅ POST - Add new customer
    [HttpPost]
    public IActionResult Create(Customer customer)
    {
        _context.Customers.Add(customer);
        _context.SaveChanges();
        return Ok(customer);
    }
}