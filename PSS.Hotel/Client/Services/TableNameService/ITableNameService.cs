namespace PSS.Hotel.Client.Services.TableNameService;

public interface ITableNameService
{
    List<TableName> TableNames { get; set; }
    Task GetAll();
}
