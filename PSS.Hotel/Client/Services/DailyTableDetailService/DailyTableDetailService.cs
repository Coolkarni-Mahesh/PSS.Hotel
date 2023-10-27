using System.Net.Http.Json;

namespace PSS.Hotel.Client.Services.DailyTableDetailService;

public class DailyTableDetailService : IDailyTableDetailService
{
    private readonly HttpClient _http;
    public List<DailyTableDetail> DailyTableDetails { get; set; } = new List<DailyTableDetail>();

    public DailyTableDetailService(HttpClient http)
    {
        _http = http;
    }
    public async Task GetAll()
    {
        var result = await _http.GetFromJsonAsync<ServiceResponse<List<DailyTableDetail>>>("api/DailyTableDetail/DailyTableDetail");

        if (result != null && result.Data != null)
            DailyTableDetails = result.Data;
    }
}
