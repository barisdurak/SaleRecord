using System;
using System.Collections.Generic;
using RestApiDemo.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiDemo.Repository
{
    public interface IProductRepository
    {

        Task<IEnumerable<Product>> GetAsync();
    }
}
