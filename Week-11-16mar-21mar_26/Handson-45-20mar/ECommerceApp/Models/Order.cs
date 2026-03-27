using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerceApp.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        // ✅ Default date
        public DateTime OrderDate { get; set; } = DateTime.Now;

        // ✅ REQUIRED FK
        [Required]
        public int CustomerId { get; set; }

        // ✅ Navigation (nullable to avoid validation error)
        public Customer? Customer { get; set; }

        // ✅ OPTIONAL (IMPORTANT FIX)
        public List<OrderItem>? OrderItems { get; set; }

        // ✅ OPTIONAL (IMPORTANT FIX)
        public ShippingDetail? ShippingDetail { get; set; }
    }
}