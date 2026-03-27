using Microsoft.AspNetCore.Mvc;
using OrderApi.DTOs;
using OrderApi.Services;

namespace OrderApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _service;

        public OrdersController(IOrderService service)
        {
            _service = service;
        }

        // ✅ POST: Create Order
        [HttpPost]
        public async Task<IActionResult> Create(OrderDto dto)
        {
            var result = await _service.CreateOrder(dto);
            return Ok(result);
        }

        // ✅ NEW: GET all orders
        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            var orders = await _service.GetOrders();
            return Ok(orders);
        }
    }
}