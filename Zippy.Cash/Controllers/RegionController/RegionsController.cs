using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Zippy.Cash.Repository.Abstract;
using Zippy.Model;

namespace Zippy.Cash.API.Controllers.RegionController
{
    [Authorize]
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{apiVersion}/[controller]")]
    public class RegionController : ControllerBase
    {
        private readonly IRegionRepository _regionRepository;
        public RegionController(IRegionRepository regionRepository)
        {
            _regionRepository = regionRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Region>> GetRegions()
        {
           var result = await _regionRepository.GetRegions();
           return Ok(result);
        }  

    }
}
