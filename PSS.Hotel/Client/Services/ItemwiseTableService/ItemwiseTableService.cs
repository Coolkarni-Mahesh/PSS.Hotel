using System.Net.Http.Json;

namespace PSS.Hotel.Client.Services.ItemwiseTableService;

public class ItemwiseTableService : IItemwiseTableService
{
    private readonly HttpClient _http;

    public List<DailyTableDetail> DailyTableDetails { get ; set; } = new List<DailyTableDetail>();

    public ItemwiseTableService(HttpClient http)
    {
        _http = http;
    }

    public async Task GetAll()
    {
        var result = await _http.GetFromJsonAsync<ServiceResponse<List<DailyTableDetail>>>("api/ItemwiseTable/ItemwiseTable");

        if (result != null && result.Data != null)
            DailyTableDetails = result.Data;
    }
}
