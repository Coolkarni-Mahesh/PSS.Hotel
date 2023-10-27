namespace PSS.Hotel.Client.Services.DailyTableDetailService;

public interface IDailyTableDetailService
{
    List<DailyTableDetail> DailyTableDetails { get; set; }
    Task GetAll();
}
