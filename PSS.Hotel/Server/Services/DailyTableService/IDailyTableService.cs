namespace PSS.Hotel.Server.Services.DailyTableService;

public interface IDailyTableService
{
    Task<ServiceResponse<List<DailyTable>>> GetAll();
}
