using Microsoft.EntityFrameworkCore;
using Model_level_Validation.Data;

var builder = WebApplication.CreateBuilder(args);

// Add MVC services
builder.Services.AddControllersWithViews();

// Add Database Context
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    ));

var app = builder.Build();

// Configure HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

// Enable CSS / JS / Bootstrap files
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Default route (Dashboard page)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Companies}/{action=Index}/{id?}");

app.Run();