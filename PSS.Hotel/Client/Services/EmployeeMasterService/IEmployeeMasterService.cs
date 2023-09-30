using PSS.Hotel.Shared;
using PSS.Hotel.Shared.Models;

namespace PSS.Hotel.Client.Services.EmployeeMasterService;

public interface IEmployeeMasterService
{  
    List<EmployeeMaster> Employees { get; set; }  
    string Message { get; set; }
    Task GetAll();
    Task<ServiceResponse<EmployeeMaster>> GetById(int Id);   
    Task<EmployeeMaster> Add(EmployeeMaster emp);
    Task<EmployeeMaster> Update(EmployeeMaster emp);
    Task Delete(EmployeeMaster emp);
}
