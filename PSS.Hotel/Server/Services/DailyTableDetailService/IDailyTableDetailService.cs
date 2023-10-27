namespace PSS.Hotel.Server.Services.DailyTableDetailService;

public interface IDailyTableDetailService
{
    Task<ServiceResponse<List<DailyTableDetail>>> GetAll();  
}
