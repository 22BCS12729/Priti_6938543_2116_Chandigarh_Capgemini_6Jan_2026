using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public double Price { get; set; }
    }
}