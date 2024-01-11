using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencyApp.Business.Exceptions
{
	public class ProductNullException : Exception
	{
        public ProductNullException():base("Product can't be null.")
        {
            
        }
        public ProductNullException(string? message) : base(message)
		{
		}
	}
}
