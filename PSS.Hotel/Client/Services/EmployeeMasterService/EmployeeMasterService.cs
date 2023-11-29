using PSS.Hotel.Shared;
using PSS.Hotel.Shared.Models;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace PSS.Hotel.Client.Services.EmployeeMasterService;

public class EmployeeMasterService : IEmployeeMasterService
{
    private readonly HttpClient _http;

    public event Action? EmployeesChanged;
    public List<EmployeeMaster> Employees { get; set; } = new List<EmployeeMaster>();
    public string Message { get; set; } = "Loading Users...";
    public EmployeeMasterService(HttpClient http)
    {
        _http = http;
    }
    public Task<EmployeeMaster> Add(EmployeeMaster emp)
    {
        throw new NotImplementedException();
    }
    public Task Delete(EmployeeMaster emp)
    {
        throw new NotImplementedException();
    }
    public async Task GetAll()
    {
        var result = await _http.GetFromJsonAsync<ServiceResponse<List<EmployeeMaster>>>("api/EmployeeMaster/Employees");
            
        if (result != null && result.Data != null)
            Employees = result.Data;     
    }
    public Task<ServiceResponse<EmployeeMaster>> GetById(int Id)
    {
        throw new NotImplementedException();
    }
    public Task<EmployeeMaster> Update(EmployeeMaster emp)
    {
        throw new NotImplementedException();
    }
    public async Task<bool> IsAuthoriezed(string Username, string Password)
    {
        var result = await _http.GetFromJsonAsync<bool>($"api/employeeMaster/Authorize?Username={Username}&Password={Password}");    
        return result;  
    }
    public async Task SearchUsers(string searchText)
    {
        var result = await _http.GetFromJsonAsync<ServiceResponse<List<EmployeeMaster>>>($"api/EmployeeMaster/SearchUser/{searchText}");
        if (result != null && result.Data != null) Employees = result.Data;
        if (Employees.Count == 0) Message = "No users found.";
        EmployeesChanged?.Invoke();
    }
    public async Task<List<string>> GetUserSearchSuggestions(string searchText)
    {
        var result = await _http.GetFromJsonAsync<ServiceResponse<List<string>>>($"api/EmployeeMaster/Searchsuggestions/{searchText}");
        if (result != null && result.Data != null)
            return result.Data;
        return null!;
    }
}
