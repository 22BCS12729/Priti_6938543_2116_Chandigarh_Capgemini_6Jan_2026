using log4net;
using log4net.Config;
using Microsoft.Extensions.DependencyInjection;
using OrderApi.Services;
using System.Reflection;

namespace OrderApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services
            builder.Services.AddControllers();

            // ✅ CORS
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                });
            });

            builder.Services.AddOpenApi();

            // ✅ Fix possible null warning
            var assembly = Assembly.GetEntryAssembly() ?? Assembly.GetExecutingAssembly();
            var logRepository = LogManager.GetRepository(assembly);
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

            builder.Services.AddScoped<IOrderService, OrderService>();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Middleware
            app.UseCors("AllowAll");   // ✅ Important

            app.UseSwagger();
            app.UseSwaggerUI();

            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}