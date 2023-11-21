using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using PSS.Hotel.Server.Services.TableNameService;

namespace PSS.Hotel.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableNameController : ControllerBase
    {
        private readonly ITableNameService _tableNameService;

        public TableNameController(ITableNameService tableNameService)
        {
            _tableNameService = tableNameService;
        }

        [HttpGet("TableName")]
        public async Task<ActionResult<ServiceResponse<List<TableName>>>> GetAll()
        {
            var result = await _tableNameService.GetAll();
            return Ok(result);
        }
    }
}
