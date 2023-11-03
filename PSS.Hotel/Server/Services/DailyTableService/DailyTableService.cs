namespace PSS.Hotel.Server.Services.DailyTableService;

public class DailyTableService : IDailyTableService
{
    private readonly ModelContext _context;

    public DailyTableService(ModelContext context)
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
