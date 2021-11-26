using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zippy.Model;

namespace Zippy.Cash.Repository.Abstract
{
    internal interface IClientRepository
    {
        Task <IEnumerable<Client>> GetClientList();
    }
}
