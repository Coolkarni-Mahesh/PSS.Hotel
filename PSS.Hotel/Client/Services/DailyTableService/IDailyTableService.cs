namespace PSS.Hotel.Client.Services.DailyTableService;

public interface IDailyTableService
{
    List<DailyTable> DailyTables { get; set; }
    Task GetAll();
}
