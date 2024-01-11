using AgencyApp.Business.Profiles;
using AgencyApp.Business.Services.Implementations;
using AgencyApp.Business.Services.Interfaces;
using AgencyApp.DAL.Context;
using AgencyApp.DAL.Repositories.Implementations;
using AgencyApp.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AgencyApp.MVC_
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			builder.Services.AddAutoMapper(typeof(ProductMapper).Assembly);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
			builder.Services.AddDbContext<AppDbContext>(opt=>
			{
				opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
			});
			builder.Services.AddScoped<IProductReposiroty, ProductReposiroty>();
			builder.Services.AddScoped<IProductServices,ProductServices>();
			

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();
            app.MapControllerRoute(
                name: "default",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}