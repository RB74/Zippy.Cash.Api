using Microsoft.EntityFrameworkCore;
using Zippy.Cash.Repository.Abstract;
using Zippy.Model;

namespace Zippy.Cash.Repository.Concrete
{
    public class RegionRepository : IRegionRepository
    {
        private readonly ZippyDBContext _dbContext;
        public RegionRepository(ZippyDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        /// <summary>
        /// Test method, temp implementation
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Region>> GetRegions()
        {
            List<Region> result = await _dbContext.Regions.ToListAsync();
            return result;
        }
    }
}
