using Microsoft.EntityFrameworkCore;
using StudentApp.Models;

namespace StudentApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // 🔥 Student Table (Case Study 1)
        public DbSet<Student> Students { get; set; }

        // 🔥 Product Table (Case Study 2)
        public DbSet<Product> Products { get; set; }
    }
}