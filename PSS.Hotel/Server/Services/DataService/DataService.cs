namespace PSS.Hotel.Server.Services.DataService;

public class DataService : IDataService
{
    private readonly ModelContext _context;

    public DataService(ModelContext context)
    {
        _context = context;
    }
    public async Task<ServiceResponse<List<Datum>>> GetAll()
    {
        var response = new ServiceResponse<List<Datum>>()
        {
            Data = await _context.Data.AsNoTracking().ToListAsync()
        };
        return response;
    }
}
