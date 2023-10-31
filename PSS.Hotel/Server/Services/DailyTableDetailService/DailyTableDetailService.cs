using Microsoft.EntityFrameworkCore;

namespace PSS.Hotel.Server.Services.DailyTableDetailService;

public class DailyTableDetailService : IDailyTableDetailService
{
    private readonly ModelContext _context;

    public DailyTableDetailService(ModelContext context)
    {
        _context = context;
    }
    public async Task<ServiceResponse<List<DailyTableDetail>>> GetAll()
    {
        var response = new ServiceResponse<List<DailyTableDetail>>()
        {
            Data = await _context.DailyTableDetails.AsNoTracking().ToListAsync()
        };
       return response;
    }
}
