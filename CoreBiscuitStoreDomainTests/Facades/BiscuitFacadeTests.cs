using CoreBiscuitStoreData;
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
        private Mock<IRepositoryFactory> _mockRepositoryFactory;

        public BiscuitFacadeTests()
        {
            _mockRepositoryFactory = new Mock<IRepositoryFactory>();
        }
        
        [Fact]
        public void GetAllBiscuitTypes_ReturnsExpectedEntities()
        {
            _facade = new BiscuitFacade(_mockRepositoryFactory.Object);
            var result = _facade.GetAllBiscuitTypes();

            Assert.False(true);
        }
    }
}
