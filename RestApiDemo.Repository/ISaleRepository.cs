using RestApiDemo.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestApiDemo.Repository
{
    public interface ISaleRepository
    {
        Task<IEnumerable<Sale>> GetAsync();
        
    }
}
