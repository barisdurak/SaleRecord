using RestApiDemo.Model;
using RestApiDemo.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestApiDemo.Service
{
    public class SaleService:ISaleService
    {
        private readonly ISaleRepository _saleRepository;

        public SaleService(ISaleRepository saleRepository)
        {
            _saleRepository = saleRepository;

        }

        public async Task<IEnumerable<Sale>> GetAsync()
        {
            return await _saleRepository.GetAsync();
        }

        public async Task<int> PostSaleAsync(Sale sale)
        {
            return await _saleRepository.PostSaleAsync(sale);
        }

        
    }
}
