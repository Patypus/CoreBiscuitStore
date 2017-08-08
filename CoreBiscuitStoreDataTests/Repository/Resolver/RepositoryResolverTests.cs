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
    }
}