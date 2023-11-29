namespace PSS.Hotel.Server.Services.EmployeeMasterService;

public interface IEmployeeMasterService
{
    Task<ServiceResponse<List<EmployeeMaster>>> GetAll();
    Task<ServiceResponse<EmployeeMaster>> GetById(int Id);
    Task<bool> IsAuthorized(string Username, string Password);
    Task<ServiceResponse<EmployeeMaster>> Add(EmployeeMaster emp);
    Task<ServiceResponse<EmployeeMaster>> Update(EmployeeMaster emp);
    Task<ServiceResponse<bool>> Delete(int Id);
    Task<ServiceResponse<List<EmployeeMaster>>> SearchUser(string searchText);
    Task<ServiceResponse<List<string>>> GetUserSearchSuggestions(string searchText);

}
