using Zippy.Model;

namespace Zippy.Cash.Repository.Abstract
{
    internal interface IClientRepository
    {
        Task<IEnumerable<Client>> GetClientList();
    }
}
