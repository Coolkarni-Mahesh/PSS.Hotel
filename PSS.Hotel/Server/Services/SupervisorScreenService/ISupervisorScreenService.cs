namespace PSS.Hotel.Server.Services.SupervisorScreenService;

public interface ISupervisorScreenService
{
    Task<ServiceResponse<List<DailyTable>>> GetAll();
}

