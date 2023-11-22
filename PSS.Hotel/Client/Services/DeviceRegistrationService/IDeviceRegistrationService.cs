namespace PSS.Hotel.Client.Services.DeviceRegistrationService;

public interface IDeviceRegistrationService
{
    event Action OnChange;
    Task Add(DeviceRegistration deviceRegistration);
    Task<List<DeviceRegistration>> GetAll();

}
