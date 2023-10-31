namespace PSS.Hotel.Client.Services.ItemwiseTableService;

public interface IItemwiseTableService
{
    List<DailyTableDetail> DailyTableDetails { get; set; }
    Task GetAll();
}
