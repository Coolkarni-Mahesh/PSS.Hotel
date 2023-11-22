using Blazored.LocalStorage;

namespace PSS.Hotel.Client.Services.DeviceRegistrationService;

public class DeviceRegistrationService : IDeviceRegistrationService
{
    private readonly ILocalStorageService _localStorageService;

    public DeviceRegistrationService(ILocalStorageService localStorageService)
    {
        _localStorageService = localStorageService;
    }

    public event Action? OnChange;

    public async Task Add(DeviceRegistration deviceRegistration)
    {
        var m = await _localStorageService.GetItemAsync<List<DeviceRegistration>>("Reg");
        if(m == null)
        {
            m = new List<DeviceRegistration>();
        }
        m.Add(deviceRegistration);

        await _localStorageService.SetItemAsync("Reg", m);
    }

    public async Task<List<DeviceRegistration>> GetAll()
    {
        var m = await _localStorageService.GetItemAsync<List<DeviceRegistration>>("Reg");
        if (m == null)
        {
            m = new List<DeviceRegistration>();
        }

        return m;       
    }
}
