using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencyApp.Business.ViewModels.ProductVMs
{
	public class ProductUpdateVM
	{
        public int Id { get; set; }
        public string Title { get; set; }
		public string Description { get; set; }
		public string Icon { get; set; }
	}
	public class ProductUpdateVMValidation : AbstractValidator<ProductCreateVM>
	{
		public ProductUpdateVMValidation()
		{
			RuleFor(X => X.Title).NotEmpty().MaximumLength(60);
			RuleFor(X => X.Description).NotEmpty().MaximumLength(60);
		}
	}
}
