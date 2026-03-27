using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerceApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Category name is required")]
        public string Name { get; set; }

        // ✅ Navigation property (NO validation here)
        public List<Product>? Products { get; set; } = new List<Product>();
    }
}