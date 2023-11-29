namespace PSS.Hotel.Server.Services.DataService;

public interface IDataService
{
    Task<ServiceResponse<List<Datum>>> GetAll();
}
