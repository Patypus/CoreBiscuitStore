using CoreBiscuitStoreData;
using CoreBiscuitStoreData.Repository.Resolver;
using CoreBiscuitStoreDomain.Facades;
using CoreBiscuitStoreDomain.Facades.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CoreBiscuitStoreDomainTests.Facades
{
    public class BiscuitFacadeTests
    {
        private IBiscuitFacade _facade;
        private Mock<IRepositoryResolver> _mockRepositoryResolver;

        public BiscuitFacadeTests()
        {
            _mockRepositoryResolver = new Mock<IRepositoryResolver>();
        }
        
        [Fact]
        public void GetAllBiscuitTypes_ReturnsExpectedEntities()
        {
            _facade = new BiscuitFacade(_mockRepositoryResolver.Object);
            var result = _facade.GetAllBiscuitTypes();

            Assert.False(true);
        }
    }
}
