using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Zippy.Cash.Repository.Abstract;
using Zippy.Model;

namespace Zippy.Cash.API.Controllers.RegionController
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RegionController : ControllerBase
    {
        private readonly IRegionRepository _regionRepository;
        public RegionController(IRegionRepository regionRepository)
        {
            _regionRepository = regionRepository;
        }

        [HttpGet]
        [Route("/GetRegions")]
        public async Task<ActionResult<Region>> GetRegions()
        {
           var result = await _regionRepository.GetRegions();
           return Ok(result);
        }  

    }
}
