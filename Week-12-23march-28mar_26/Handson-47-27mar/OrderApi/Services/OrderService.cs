using log4net;
using OrderApi.DTOs;
using OrderApi.Models;

namespace OrderApi.Services
{
    public interface IOrderService
    {
        Task<string> CreateOrder(OrderDto dto);

        // ✅ ADD THIS
        Task<List<Order>> GetOrders();
    }

    public class OrderService : IOrderService
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(OrderService));

        // ✅ ADD STORAGE (in-memory list)
        private static List<Order> orders = new List<Order>();

        public OrderService()
        {
        }

        public async Task<string> CreateOrder(OrderDto dto)
        {
            log.Info("Order creation started");

            if (dto.Quantity <= 0)
            {
                log.Warn("Invalid quantity");
                return "Invalid quantity";
            }

            try
            {
                var order = new Order
                {
                    ProductId = dto.ProductId,
                    Quantity = dto.Quantity
                };

                // ✅ STORE ORDER
                orders.Add(order);

                await Task.Delay(100);

                log.Info("Order created successfully");

                return "Order Created";
            }
            catch (Exception ex)
            {
                log.Error("Order failed", ex);
                throw;
            }
        }

        // ✅ NEW METHOD (GET ORDERS)
        public Task<List<Order>> GetOrders()
        {
            return Task.FromResult(orders);
        }
    }
}