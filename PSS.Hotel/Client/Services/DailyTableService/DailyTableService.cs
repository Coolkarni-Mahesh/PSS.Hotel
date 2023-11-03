using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace PSS.Hotel.Client.Services.DailyTableService;

public class DailyTableService : IDailyTableService
{
    private readonly HttpClient _http;

    public List<DailyTable> DailyTables { get; set; } = new List<DailyTable>();

    public DailyTableService(HttpClient http)
    {
        _http = http;
    }
    public async Task GetAll()
    {
        var result = await _http.GetFromJsonAsync<ServiceResponse<List<DailyTable>>>("api/DailyTable/DailyTable");

        if (result != null && result.Data != null)
            DailyTables = result.Data;
    }
}
