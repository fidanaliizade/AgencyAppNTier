using AgencyApp.Business.Services.Implementations;
using AgencyApp.Business.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencyApp.Business
{
    public static class ServiceRegistration
    {
        public static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IProductServices, ProductServices>();
        }
    }
}
