using System.Net.Http.Json;

namespace PSS.Hotel.Client.Services.SectionMasterService;

public class SectionMasterService : ISectionMasterService
{
    private readonly HttpClient _http;

    public List<SectionMaster> Sections { get; set; } = new List<SectionMaster>();

    public SectionMasterService(HttpClient http)
    {
        _http = http;
    }

    public async Task GetAll()
    {
        var result = await _http.GetFromJsonAsync<ServiceResponse<List<SectionMaster>>>("api/SectionMaster/SectionwiseTables");
        if (result != null && result.Data != null)
            Sections = result.Data;
    }
}
