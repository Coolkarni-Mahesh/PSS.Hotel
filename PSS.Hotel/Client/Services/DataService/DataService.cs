using PSS.Hotel.Shared.Models;
using System.Net.Http.Json;

namespace PSS.Hotel.Client.Services.DataService;

public class DataService : IDataService
{
    private readonly HttpClient _http;

    public List<Datum> Datas { get; set; } = new List<Datum>();

    public DataService(HttpClient http)
    {
        _http = http;
    }
    public async Task GetAll()
    {

        var result = await _http.GetFromJsonAsync<ServiceResponse<List<Datum>>>("api/Data/Data");

        if (result != null && result.Data != null)
            Datas = result.Data;
    }
}
