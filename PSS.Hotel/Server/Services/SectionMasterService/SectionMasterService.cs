namespace PSS.Hotel.Server.Services.SectionMasterService;

public class SectionMasterService : ISectionMasterService
{
    private readonly ModelContext _context;

    public SectionMasterService(ModelContext context)
    {
        _context = context;
    }
    public async Task<ServiceResponse<List<SectionMaster>>> GetAll()
    {
        var response = new ServiceResponse<List<SectionMaster>>()
        {
            Data = await _context.SectionMasters.AsNoTracking().ToListAsync()
        };
        return response;
    }
}
