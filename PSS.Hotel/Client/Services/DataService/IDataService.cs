namespace PSS.Hotel.Client.Services.DataService;

public interface IDataService
{
    List<Datum> Datas { get; set; }
    Task GetAll();
}
