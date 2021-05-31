using RestApiDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiDemo.Repository
{
    public interface IStoreRepository
    {
        Task<IEnumerable<Store>> GetAsync();
    }
}
