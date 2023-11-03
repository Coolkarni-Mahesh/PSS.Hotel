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
        try
        {
            var response = new ServiceResponse<List<DailyTableDetail>>()
            {
                Data = await _context.DailyTableDetails.Include("itemMaster").AsNoTracking().ToListAsync()
            };
            return response;
        }
        catch (Exception)
        {

            throw;
        }
    }
}
