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
    public class StoreController : ControllerBase
    {
        private readonly IStoreService _storeService;

        public StoreController(IStoreService storeService)
        {
            _storeService = storeService;

        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            try
            {
                var res = await _storeService.GetAsync();
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
