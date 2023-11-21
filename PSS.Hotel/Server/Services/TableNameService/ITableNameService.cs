namespace PSS.Hotel.Server.Services.TableNameService;

public interface ITableNameService
{
    Task<ServiceResponse<List<TableName>>> GetAll();
}
