namespace PSS.Hotel.Client.Services.DailyTableDetailService;

public interface IDailyTableDetailService
{
    List<DailyTableDetail> DailyTableDetails { get; set; }
    DailyTableDetail SingleDailyTableDetail { get; set; }
    Task GetAll();
    Task GetByKotNo(int kotNo);
    Task GetByID(int? ID);
    Task<DailyTableDetail> Update(DailyTableDetail dailyTableDetail);

}
