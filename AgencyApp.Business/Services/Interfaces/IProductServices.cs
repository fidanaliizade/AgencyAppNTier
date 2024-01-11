using AgencyApp.Business.ViewModels.ProductVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencyApp.Business.Services.Interfaces
{
	public interface IProductServices
	{
		public Task<IEnumerable<ProductListItemVM>> GetAll();
		public Task<ProductDetailVM> GetById(int id);
		public Task Create(ProductCreateVM vm);
		public Task Update(ProductUpdateVM vm);
		public Task Delete(int id);
	}
}
