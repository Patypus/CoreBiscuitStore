using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using CoreBiscuitStoreData;

namespace CoreBiscuitStoreDomain.Setup
{
    public static class DependancyInjectionSetup
    {
        public static void RegisterDomainDependancies(IServiceCollection services)
        {
            services.AddTransient<IRepositoryFactory, RepositoryFactory>();
        }
    }
}
