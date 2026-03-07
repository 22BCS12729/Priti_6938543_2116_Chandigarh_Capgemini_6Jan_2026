var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// ✅ Middleware pipeline (Task-4 requirement)
app.UseExceptionHandler("/error");
app.UseHttpsRedirection();
app.UseRouting();

// ✅ Endpoint
app.MapGet("/", () => "Hello from Task 4 - Middleware");

app.Run();
