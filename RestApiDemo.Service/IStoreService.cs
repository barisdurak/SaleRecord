using RestApiDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiDemo.Service
{
    public interface IStoreService
    {
        Task<IEnumerable<Store>> GetAsync();
    }
}
