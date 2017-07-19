using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreBiscuitStore.Models.Product;
using CoreBiscuitStoreDomain.Facades.Interfaces;

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
            var tempModel = new List<BiscuitViewModel>
            {
                new BiscuitViewModel { Name = "1" }
            };

            return View(tempModel);
        }
    }
}