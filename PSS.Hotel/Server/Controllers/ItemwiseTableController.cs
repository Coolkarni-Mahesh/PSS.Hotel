using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PSS.Hotel.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ItemwiseTableController : ControllerBase
{
    private readonly IItemwiseTableService _itemwiseTableService;

    public ItemwiseTableController(IItemwiseTableService itemwiseTableService)
    {
        _itemwiseTableService = itemwiseTableService;
    }


    [HttpGet("ItemwiseTable")]
    public async Task<ActionResult<ServiceResponse<List<DailyTableDetail>>>> GetAll()
    {
        var result = await _itemwiseTableService.GetAll();
        return Ok(result);
    }
}
