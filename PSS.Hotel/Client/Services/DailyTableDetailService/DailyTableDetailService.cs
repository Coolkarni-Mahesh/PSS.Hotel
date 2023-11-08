using System.Net.Http.Json;

namespace PSS.Hotel.Client.Services.DailyTableDetailService;

public class DailyTableDetailService : IDailyTableDetailService
{
    private readonly HttpClient _http;
    public List<DailyTableDetail> DailyTableDetails { get; set; } = new List<DailyTableDetail>();
    public DailyTableDetail SingleDailyTableDetail { get; set; } = new DailyTableDetail();

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
    public async Task GetByID(int? ID)
    {
        var result = await _http.GetFromJsonAsync<ServiceResponse<DailyTableDetail>>($"api/DailyTableDetail/DailyTableDetail1?ID={ID}");
        if (result != null && result.Data != null)
            SingleDailyTableDetail = result.Data;
    }
    public async Task GetByKotNo(int kotNo)
    {
        var result = await _http.GetFromJsonAsync<ServiceResponse<List<DailyTableDetail>>>($"api/DailyTableDetail/DailyTableDetail2?KotNo={kotNo}");
        if (result != null && result.Data != null)
            DailyTableDetails = result.Data;
    }
    public async Task<DailyTableDetail> Update(DailyTableDetail dailyTableDetail)
    {
        var result = await _http.PutAsJsonAsync($"api/DailyTableDetail?ID={dailyTableDetail.DailyTableDetailId}", dailyTableDetail);
        var content = await result.Content.ReadFromJsonAsync<ServiceResponse<DailyTableDetail>>();
        return content!.Data!;
    }


}