using Microsoft.AspNetCore.Mvc;
using PSS.Hotel.Server.Services;

namespace PSS.Hotel.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeeMasterController : ControllerBase
{
    private readonly IEmployeeMasterService _employeeMasterService;

    public EmployeeMasterController(IEmployeeMasterService employeeMasterService)
    {
        _employeeMasterService = employeeMasterService;
    }

    [HttpGet("Employees")]
    public async Task<ActionResult<ServiceResponse<List<EmployeeMaster>>>> GetAll()
    {
        var result = await _employeeMasterService.GetAll();
        return Ok(result);
    }


}
