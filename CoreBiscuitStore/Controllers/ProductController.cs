using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreBiscuitStore.Models.Product;

namespace CoreBiscuitStore.Controllers
{
    public class ProductController : Controller
    {
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