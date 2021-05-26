using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApiDemo.Model;
using RestApiDemo.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly ISaleService _saleService;

        public SaleController(ISaleService saleService)
        {
            _saleService = saleService;

        }

        [HttpGet]

        public async Task <IActionResult> Get(){
            try
            {
                var res = await _saleService.GetAsync();
                return Ok(res);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                throw;
            }
        }

        [HttpPost]

        public async Task <IActionResult> PostSale(Sale sale)
        {
            try
            {
                var res = await _saleService.PostSaleAsync(sale);
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
