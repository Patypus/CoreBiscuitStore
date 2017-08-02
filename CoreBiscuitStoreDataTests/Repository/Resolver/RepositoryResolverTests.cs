using CoreBiscuitStoreCommon.Settings;
using CoreBiscuitStoreData.Entities;
using CoreBiscuitStoreData.Repository;
using CoreBiscuitStoreData.Repository.Resolver;
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Runtime.Loader;
using System.Linq;
using CoreBiscuitStoreData.Repository.Interfaces;

namespace CoreBiscuitStoreDataTests.Repository.Resolver
{
    public class RepositoryResolverTests
    {
        private ApplicationConfiguration testConfiguration = new ApplicationConfiguration();

        [Fact]
        public void GetRepository_ReturnsCorrectImplementationForBiscuit()
        {
            var resolver = new RepositoryResolver(testConfiguration);

            var result = resolver.GetRepository<Biscuit>();

            Assert.True(result.GetType() == typeof(BiscuitRepository));
        }

        [Fact]
        public void AllEntitiesHaveRepositoryImplementation()
        {
            var assemblyTypes = typeof(RepositoryResolver).GetTypeInfo().Assembly.GetTypes();

            var entitiyTypes = assemblyTypes.Where(type => type is IEntity);

    //        var thingsThere = entitiyTypes.All(entityType => entityType is IRepository);

    //        var repositoryTypes = assemblyTypes.Where(type => type is IRepository);
    //        var types = .GetTypes().Where(type => type);
    //        types.ToList();
    //        AssemblyLoadContext.GetLoadContext(). GetLoadedAssemblies()  System.Reflection.App AppDomain.CurrentDomain.GetAssemblies()
    //.SelectMany(s => s.GetTypes())
    //.Where(p => type.IsAssignableFrom(p));

    //        Assert.True(false);
        }
    }
}