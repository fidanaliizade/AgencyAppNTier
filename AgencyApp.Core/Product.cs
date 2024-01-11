using AgencyApp.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencyApp.Core
{
	public class Product:BaseEntity
	{
        public string Title { get; set; }
        public string Description { get; set; }
        public string? Icon { get; set; }
    }
}
