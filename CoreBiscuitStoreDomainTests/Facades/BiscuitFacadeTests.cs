using CoreBiscuitStoreDomain.Facades;
using CoreBiscuitStoreDomain.Facades.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CoreBiscuitStoreDomainTests.Facades
{
    public class BiscuitFacadeTests
    {
        private readonly IBiscuitFacade _facade;

        public BiscuitFacadeTests()
        {
            _facade = new BiscuitFacade();
        }

        [Fact]
        public void GetAllBiscuitTypes_ReturnsExpectedEntities()
        {
            var result = _facade.GetAllBiscuitTypes();
            Assert.False(true);
        }
    }
}
