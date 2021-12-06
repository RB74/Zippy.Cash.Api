using Microsoft.EntityFrameworkCore;
using Zippy.Cash.Repository.Abstract;
using Zippy.Model;

namespace Zippy.Cash.Repository.Concrete
{
    public class ClientRepository : IClientRepository
    {
        private readonly ZippyDBContext _dbContext;
        public ClientRepository(ZippyDBContext context)
        {
            _dbContext = context;
        }
        /// <summary>
        /// Test method, temp implementation
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Client>> GetClientList()
        {
            List<Client> result = await _dbContext.Clients.ToListAsync();
            return result;
        }
    }
}
