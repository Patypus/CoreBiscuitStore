using CoreBiscuitStore.Controllers;
using CoreBiscuitStore.Models.Product;
using CoreBiscuitStoreDomain.Dtos;
using CoreBiscuitStoreDomain.Facades.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace CoreBiscuitStoreWebTests.Controllers
{
    public class ProductControllerTest
    {
        private ProductController _controller;

        [Fact]
        public void List_ReturnsListFromBiscuitFacade()
        {
            var mockBiscuitFacade = new Mock<IBiscuitFacade>();

            var testData = new List<BiscuitDto>
            {
                new BiscuitDto { Id = 1, Name = "biscuit 1" },
                new BiscuitDto { Id = 2, Name = "biscuit 2" },
                new BiscuitDto { Id = 3, Name = "biscuit 3" }
            };

            mockBiscuitFacade.Setup(mock => mock.GetAllBiscuitTypes())
                             .Returns(testData);

            _controller = new ProductController(mockBiscuitFacade.Object);

            var result = _controller.List() as ViewResult;
            var returnedData = result.Model as IEnumerable<BiscuitViewModel>;

            Assert.NotNull(returnedData);
            Assert.Equal(testData.Count, returnedData.Count());

            var expedtedIds = testData.Select(dto => dto.Id);
            var actualIds = returnedData.Select(viewModel => viewModel.Id);
            Assert.Equal(expedtedIds, actualIds);

            var expedtedNames = testData.Select(dto => dto.Name);
            var actualNames = returnedData.Select(viewModel => viewModel.Name);
            Assert.Equal(expedtedIds, actualIds);
        }
    }
}
