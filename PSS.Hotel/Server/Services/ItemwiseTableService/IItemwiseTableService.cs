namespace PSS.Hotel.Server.Services.ItemwiseTableService;

public interface IItemwiseTableService
{
    Task<ServiceResponse<List<DailyTableDetail>>> GetAll();
}
