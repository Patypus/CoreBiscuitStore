using Microsoft.Extensions.DependencyInjection;
using CoreBiscuitStoreData.Repository.Resolver;

namespace CoreBiscuitStoreDomain.Setup
{
    public static class DependancyInjectionSetup
    {
        public static void RegisterDomainDependancies(IServiceCollection services)
        {
            services.AddTransient<IRepositoryResolver, RepositoryResolver>();
        }
    }
}