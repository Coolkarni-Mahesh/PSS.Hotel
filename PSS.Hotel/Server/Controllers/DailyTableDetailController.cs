using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PSS.Hotel.Server.Services.DailyTableDetailService;

namespace PSS.Hotel.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DailyTableDetailController : ControllerBase
    {
        private readonly IDailyTableDetailService _dailyTableDetailService;

        public DailyTableDetailController(IDailyTableDetailService dailyTableDetailService)
        {
            _dailyTableDetailService = dailyTableDetailService;
        }

        [HttpGet("DailyTableDetail")]
        public async Task<ActionResult<ServiceResponse<List<DailyTableDetail>>>> GetAll()
        {
           var result = await _dailyTableDetailService.GetAll();
           return Ok(result);
        }
    }
}
