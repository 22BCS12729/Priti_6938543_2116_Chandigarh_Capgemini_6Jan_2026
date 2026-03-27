using Microsoft.EntityFrameworkCore;
using BankAPI.Models;

namespace BankAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
    }
}