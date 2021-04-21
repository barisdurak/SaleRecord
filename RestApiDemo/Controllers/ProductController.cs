using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApiDemo.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {

            _productService = productService;
        }

        [HttpGet]

        public async Task<IActionResult> Get() {
            try
            {
                var res = await _productService.GetAsync();
                return Ok(res);

            }
            catch (Exception e)
            {

                Console.WriteLine(e);

                throw;
            }

        }



    }
}
