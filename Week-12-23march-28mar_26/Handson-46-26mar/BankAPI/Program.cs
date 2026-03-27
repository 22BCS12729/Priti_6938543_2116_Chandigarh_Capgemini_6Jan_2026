using BankAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

// Swagger / OpenAPI
builder.Services.AddOpenApi();

// ✅ Add InMemory Database
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("BankDb"));

// ✅ Add AutoMapper
builder.Services.AddAutoMapper(typeof(Program));

// ✅ Add Authentication (JWT - basic)
builder.Services.AddAuthentication("Bearer")
    .AddJwtBearer("Bearer", options =>
    {
    });

// ✅ Add Authorization
builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// ✅ VERY IMPORTANT (ADD THIS)
app.UseDefaultFiles();   // 👈 loads index.html automatically

// ✅ Static files
app.UseStaticFiles();

app.UseHttpsRedirection();

// ✅ Auth
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run(); // ✅ MUST BE LAST