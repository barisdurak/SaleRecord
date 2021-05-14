using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using RestApiDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace RestApiDemo.Repository
{
    public class SaleRepository : ISaleRepository
    {
        private readonly IConfiguration _configuration;

        public SaleRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<Sale>> GetAsync()
        {
            try
            {
                using (var connection = DataLayer.GetConnection(_configuration))
                {
                    var res = await connection.GetAllAsync<Sale>();
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
