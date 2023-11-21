namespace PSS.Hotel.Server.Services.TableNameService;

public class TableNameService : ITableNameService
{
    private readonly ModelContext _context;

    public TableNameService(ModelContext context)
    {
        _context = context;
    }
    public async Task<ServiceResponse<List<TableName>>> GetAll()
    {
        var response = new ServiceResponse<List<TableName>>()
        {
            Data = await _context.TableNames.AsNoTracking().ToListAsync()
        };
        return response;
    }
}
