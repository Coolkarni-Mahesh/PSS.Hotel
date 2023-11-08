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
            try
            {
                var result = await _dailyTableDetailService.GetAll();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("DailyTableDetail1")]
        public async Task<ActionResult<DailyTableDetail>> GetByID(int ID)
        {
            try
            {
                var result = await _dailyTableDetailService.GetByID(ID);
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("DailyTableDetail2")]
        public async Task<ActionResult<List<DailyTableDetail>>> GetByKotNo(int KotNo)
        {
            try
            {
                var result = await _dailyTableDetailService.GetByKotNo(KotNo);
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut]
        public  async Task<ActionResult<ServiceResponse<DailyTableDetail>>> Update(DailyTableDetail dailyTableDetail)
        {
            try
            {
               var result =  await _dailyTableDetailService.Update(dailyTableDetail);
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
