using AgencyApp.Core;
using AgencyApp.DAL.Context;
using AgencyApp.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencyApp.DAL.Repositories.Implementations
{
	public class ProductReposiroty : Reposiroty<Product>, IProductReposiroty
	{
		public ProductReposiroty(AppDbContext db) : base(db)
		{
		}
	}
}
