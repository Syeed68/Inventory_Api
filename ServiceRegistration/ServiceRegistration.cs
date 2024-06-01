using BLL.IRepositories;
using BLL.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceRegistration
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IBranchRepository, BranchRepository>();
        }
    }
}
