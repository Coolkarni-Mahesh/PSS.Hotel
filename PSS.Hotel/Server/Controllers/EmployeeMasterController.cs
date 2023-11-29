using Microsoft.AspNetCore.Mvc;

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

    [HttpGet("Authorize")]
    public async Task<bool> IsAuthorized(string Username, String Password)
    {
        var result = await _employeeMasterService.IsAuthorized(Username, Password);
        return result;
    }

    [HttpGet("SearchUser/{SearchText}")]
    public async Task<ActionResult<ServiceResponse<List<EmployeeMaster>>>> SearchUsers(string SearchText)
    {
        var result = await _employeeMasterService.SearchUser(SearchText);
        return Ok(result);
    }
    [HttpGet("Searchsuggestions/{SearchText}")]
    public async Task<ActionResult<ServiceResponse<List<EmployeeMaster>>>> GetUserSearchSuggestions(string SearchText)
    {
        var result = await _employeeMasterService.GetUserSearchSuggestions(SearchText);
        return Ok(result);
    }
}
