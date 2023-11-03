using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PSS.Hotel.Server.Services.SupervisorScreenService;

namespace PSS.Hotel.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupervisorScreenController : ControllerBase
    {
        private readonly ISupervisorScreenService _supervisorScreenService;

        public SupervisorScreenController(ISupervisorScreenService supervisorScreenService)
        {
            _supervisorScreenService = supervisorScreenService;
        }

        [HttpGet("SupervisorScreen")]
        public async Task<ActionResult<ServiceResponse<List<DailyTable>>>> GetAll()
        {
            var result = await _supervisorScreenService.GetAll();
            return Ok(result);
        }
    }
}
