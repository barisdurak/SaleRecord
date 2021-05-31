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
    public class StoreRepository:IStoreRepository
    {

        private readonly IConfiguration _configuration;

        public StoreRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<Store>> GetAsync()
        {
            try
            {
                using (var connection = DataLayer.GetConnection(_configuration))
                {
                    var res = await connection.GetAllAsync<Store>();
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
