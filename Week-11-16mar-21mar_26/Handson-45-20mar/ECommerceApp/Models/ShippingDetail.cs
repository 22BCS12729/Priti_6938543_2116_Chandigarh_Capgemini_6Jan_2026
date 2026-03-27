using System.ComponentModel.DataAnnotations;

namespace ECommerceApp.Models
{
    public class ShippingDetail
    {
        public int Id { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Status { get; set; }

        // Foreign Key
        public int OrderId { get; set; }

        public Order Order { get; set; }
    }
}