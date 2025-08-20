using Microsoft.EntityFrameworkCore;
using ProductManagement.Models;
using ProductManagement.PMModels;

namespace ProductManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();



            builder.Services.AddControllersWithViews();

            builder.Services.AddAutoMapper(typeof(MappingProfile));

            builder.Services.AddDbContext<ProductManagementContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
        );

            var app = builder.Build();

        


            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=ProductManagement}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
