using Zippy.Model;

namespace Zippy.Cash.Repository.Abstract
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetRegions();
    }
}
