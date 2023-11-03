using Microsoft.EntityFrameworkCore;

namespace PSS.Hotel.Server.Services.SupervisorScreenService;

public class SupervisorScreenService : ISupervisorScreenService
{
    private readonly ModelContext _context;

    public SupervisorScreenService(ModelContext context)
    {
        _context = context;
    }

    public async Task<ServiceResponse<List<DailyTable>>> GetAll()
    {

        var response = new ServiceResponse<List<DailyTable>>()
        {
            Data = await _context.DailyTables.Include("employeeMaster").AsNoTracking().ToListAsync()
        };
        return response;

    }
}
