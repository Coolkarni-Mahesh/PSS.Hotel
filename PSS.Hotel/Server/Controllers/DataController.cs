using Microsoft.AspNetCore.Mvc;

namespace PSS.Hotel.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DataController : ControllerBase
{
    private readonly IDataService _dataService;

    public DataController(IDataService dataService)
    {
        _dataService = dataService;
    }

    [HttpGet("Data")]
    public async Task<ActionResult<ServiceResponse<List<Datum>>>> GetAll()
    {
        var result = await _dataService.GetAll();
        return Ok(result);
    }
}
