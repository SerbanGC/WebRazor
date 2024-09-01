using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using razor.Services;
using razor.Models;
namespace razor.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private JsonFileProductService service { get; }

        public ProductsController(JsonFileProductService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return service.GetProducts();
        }
    }
}