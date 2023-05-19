using Microsoft.EntityFrameworkCore;
using MVCDemoAssignment.Context;
using MVCDemoAssignment.Interfaces;
using MVCDemoAssignment.Repo;

namespace MVCDemoAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            builder.Services.AddDbContext<MarketDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("MarketDbConnection"));

            });

            builder.Services.AddTransient<ISupplierInterface, SupplierRepo>();
            builder.Services.AddTransient<IInventoryInterface, InventoryRepo>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}