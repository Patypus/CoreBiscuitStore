using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreBiscuitStore.Models.Product;
using CoreBiscuitStoreDomain.Facades.Interfaces;
using CoreBiscuitStoreDomain.Dtos;

namespace CoreBiscuitStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IBiscuitFacade _biscuitFacade;

        public ProductController(IBiscuitFacade biscuitFacade)
        {
            _biscuitFacade = biscuitFacade;
        }

        public IActionResult List()
        {
            //var allProductDtos = new List<BiscuitDto>
            //{
            //    new BiscuitDto { Id = 1, Name = "1" },
            //    new BiscuitDto { Id = 2, Name = "2" },
            //    new BiscuitDto { Id = 3, Name = "3" }
            //};

            var allProductDtos = _biscuitFacade.GetAllBiscuitTypes();
            var modelList = allProductDtos.Select(ConvertBiscuitDtoToViewModel);

            return View(modelList);
        }

        private BiscuitViewModel ConvertBiscuitDtoToViewModel(BiscuitDto dto)
        {
            return new BiscuitViewModel
            {
                Id = dto.Id,
                Name = dto.Name
            };
        }
    }
}