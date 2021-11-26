using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zippy.Cash.Repository.Abstract;
using Zippy.Model;

namespace Zippy.Cash.Repository.Concrete
{
    public class ClientRepository:IClientRepository
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
        public async Task <IEnumerable<Client>>GetClientList()
        {
            var result = await _dbContext.Clients.ToListAsync();
            return result;
        }

       
    }
}
