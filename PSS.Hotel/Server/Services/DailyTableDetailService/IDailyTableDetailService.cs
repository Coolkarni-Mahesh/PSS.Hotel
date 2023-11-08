namespace PSS.Hotel.Server.Services.DailyTableDetailService;

public interface IDailyTableDetailService
{
    Task<ServiceResponse<List<DailyTableDetail>>> GetAll();
    Task<ServiceResponse<List<DailyTableDetail>>> GetByKotNo(int KotNo);
    Task<ServiceResponse<DailyTableDetail>> GetByID(int ID);
    Task<ServiceResponse<DailyTableDetail>> Update(DailyTableDetail dailyTableDetail);

}
