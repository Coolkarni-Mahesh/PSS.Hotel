using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PSS.Hotel.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DailyTableController : ControllerBase
    {
        private readonly IDailyTableService _dailyTableService;

        public DailyTableController(IDailyTableService dailyTableService)
        {
            _dailyTableService = dailyTableService;
        }


        [HttpGet("DailyTable")]
        public async Task<ActionResult<ServiceResponse<List<DailyTable>>>> GetAll()
        {
            var result = await _dailyTableService.GetAll();
            return Ok(result);
        }
    }
}
