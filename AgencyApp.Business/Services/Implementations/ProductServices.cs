using AgencyApp.Business.Exceptions;
using AgencyApp.Business.Exceptions.Common;
using AgencyApp.Business.Services.Interfaces;
using AgencyApp.Business.ViewModels.ProductVMs;
using AgencyApp.Core;
using AgencyApp.DAL.Repositories.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencyApp.Business.Services.Implementations
{
	public class ProductServices : IProductServices
	{
		private readonly IProductReposiroty _reposiroty;
		private readonly IMapper _mapper;

		public ProductServices(IProductReposiroty reposiroty, IMapper mapper)
		{
			_reposiroty = reposiroty;
			_mapper = mapper;
		}
		public async Task Create(ProductCreateVM vm)
		{
			var product = _mapper.Map<ProductCreateVM,Product>(vm);
			await _reposiroty.Create(product);
			await _reposiroty.SaveChanges();
		}

		public async Task Delete(int id)
		{
			if (id <= 0) throw new NegativeIdException();
			await _reposiroty.Delete(id);
			await _reposiroty.SaveChanges();

		}

		public async Task<IEnumerable<ProductListItemVM>> GetAll()
		{
			var products = await _reposiroty.GetAllAsync();
			return _mapper.Map<IEnumerable<ProductListItemVM>>(products);

		}

		public async Task<ProductDetailVM> GetById(int id)
		{
			if(id<=0) throw new NegativeIdException();
			var product = await _reposiroty.GetByIdAsync(id);
			return _mapper.Map<ProductDetailVM>(product);
		}

		public async Task Update(ProductUpdateVM vm)
		{
			if(vm.Id<=0) throw new NegativeIdException();
			if (await _reposiroty.GetByIdAsync(vm.Id) == null) throw new ProductNullException();
			var product = await _reposiroty.GetByIdAsync(vm.Id);
			_reposiroty.Update(_mapper.Map(vm, product));
			_reposiroty.SaveChanges();
		}
	}
}
