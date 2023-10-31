namespace PSS.Hotel.Server.Services.ItemwiseTableService;

public class ItemwiseTableService : IItemwiseTableService
{
    private readonly ModelContext _context;

    public ItemwiseTableService(ModelContext context)
    {
        _context = context;
    }
    public async Task<ServiceResponse<List<DailyTableDetail>>> GetAll()
    {
        var response = new ServiceResponse<List<DailyTableDetail>>()
        {
            Data = await _context.DailyTableDetails.Include("itemMaster").Where(temp => temp.Kotbot == "K").AsNoTracking().ToListAsync()
        };
        return response;
    }
}
