using AgencyApp.Business.ViewModels.ProductVMs;
using AgencyApp.Core;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencyApp.Business.Profiles
{
	public class ProductMapper:Profile
	{
        public ProductMapper()
        {
            CreateMap<Product, ProductCreateVM>();
            CreateMap<Product, ProductCreateVM>().ReverseMap();
            CreateMap<Product, ProductUpdateVM>();
			CreateMap<Product, ProductUpdateVM>().ReverseMap();
            CreateMap<Product,ProductListItemVM>();
            CreateMap<Product, ProductListItemVM>().ReverseMap();
            CreateMap<ProductUpdateVM, ProductDetailVMValidation>();
            CreateMap<ProductUpdateVM, ProductDetailVMValidation>().ReverseMap();
        }
    }
}
