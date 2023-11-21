using System.Net.Http.Json;

namespace PSS.Hotel.Client.Services.TableNameService;

public class TableNameService : ITableNameService
{
    private readonly HttpClient _http;

    public List<TableName> TableNames { get; set; } = new List<TableName>();

    public TableNameService(HttpClient http)
    {
        _http = http;
    }
    public async Task GetAll()
    {
        var result = await _http.GetFromJsonAsync<ServiceResponse<List<TableName>>>("api/TableName/TableName");

        if (result != null && result.Data != null)
            TableNames = result.Data;
    }
}
