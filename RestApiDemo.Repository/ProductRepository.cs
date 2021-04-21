using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using RestApiDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiDemo.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IConfiguration _configuration;

        public ProductRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<Product>> GetAsync()
        {
            try
            {
                using (var connection = DataLayer.GetConnection(_configuration))
                {
                    var res = await connection.GetAllAsync<Product>();
                    return res;


                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


    }
}
