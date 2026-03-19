using Microsoft.EntityFrameworkCore;
using WebAppDemo.Models;

namespace WebAppDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add MVC services
            builder.Services.AddControllersWithViews();

            // Get connection string from appsettings.json
            var cs1 = builder.Configuration.GetConnectionString("cs1");

            // Register DbContext
            builder.Services.AddDbContext<EmployeeDBContext>(options =>
                options.UseSqlServer(cs1));

            var app = builder.Build();

            // Error handling
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            // Enable static files (CSS, JS, images)
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            // Default route
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}