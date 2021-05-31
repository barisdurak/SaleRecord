using RestApiDemo.Model;
using RestApiDemo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiDemo.Service
{
    public class StoreService:IStoreService
    {
        private readonly IStoreRepository _storeRepository;

        public StoreService(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;

        }

        public async Task<IEnumerable<Store>> GetAsync()
        {
            return await _storeRepository.GetAsync();
        }

        

    }
}

