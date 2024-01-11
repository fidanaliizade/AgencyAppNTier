using AgencyApp.Core;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AgencyApp.DAL.Context
{
	public class AppDbContext : IdentityDbContext<AppUser>
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
			base.OnModelCreating(builder);
		}

		public DbSet<Product> Products { get; set; }
		public class YourDbContextFactory :IDesignTimeDbContextFactory<AppDbContext>
		{
			public AppDbContext CreateDbContext(string[] args)
			{
				var optionsBuilder =new DbContextOptionsBuilder<AppDbContext>();
				optionsBuilder.UseSqlServer("Server=localdb\\MSSQLLocalDB;Database=AgencyApp;Trusted_Connection=True");

            return new AppDbContext(optionsBuilder.Options);
			}
		}
	}
}
