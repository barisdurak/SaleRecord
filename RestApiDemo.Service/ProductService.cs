using RestApiDemo.Model;
using RestApiDemo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiDemo.Service
{
    public class ProductService:IProductService
    {

        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;

        }

        public async Task<IEnumerable<Product>> GetAsync()
        {
            return await _productRepository.GetAsync();
        }


    }
}
