using System.ComponentModel.DataAnnotations;

namespace Model_level_Validation.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Employee name required")]
        public string? Name { get; set; }

        public int CompanyId { get; set; }

        // Navigation Property
        public Company? Company { get; set; }
    }
}