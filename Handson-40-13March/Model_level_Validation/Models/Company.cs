using System.Collections.Generic;

namespace Model_level_Validation.Models
{
    public class Company
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        // Navigation property
        public List<Employee>? Employees { get; set; }
    }
}