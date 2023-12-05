using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PSS.Hotel.Server.Services.SectionMasterService;

namespace PSS.Hotel.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectionMasterController : ControllerBase
    {
        private readonly ISectionMasterService _sectionMasterService;

        public SectionMasterController(ISectionMasterService sectionMasterService)
        {
            _sectionMasterService = sectionMasterService;
        }

        [HttpGet("SectionwiseTables")]
        public async Task <ActionResult<ServiceResponse<List<SectionMaster>>>> GetAll()
        {
            return await _sectionMasterService.GetAll(); 
        }
    }
}
