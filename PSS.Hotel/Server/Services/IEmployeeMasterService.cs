namespace PSS.Hotel.Server.Services;

public interface IEmployeeMasterService
{
    Task<ServiceResponse<List<EmployeeMaster>>> GetAll();
    Task<ServiceResponse<EmployeeMaster>> GetById(int Id);   
    Task<ServiceResponse<EmployeeMaster>> Add(EmployeeMaster emp);
    Task<ServiceResponse<EmployeeMaster>> Update(EmployeeMaster emp);
    Task<ServiceResponse<bool>> Delete(int Id);
}
