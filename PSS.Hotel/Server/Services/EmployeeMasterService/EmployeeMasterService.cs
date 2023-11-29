using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;

namespace PSS.Hotel.Server.Services.EmployeeMasterService;

public class EmployeeMasterService : IEmployeeMasterService
{
    private readonly ModelContext _context;
    public EmployeeMasterService(ModelContext context)
    {
        _context = context;
    }
    public async Task<ServiceResponse<EmployeeMaster>> Add(EmployeeMaster emp)
    {
        _context.EmployeeMasters.Add(emp);
        await _context.SaveChangesAsync();
        return new ServiceResponse<EmployeeMaster> { Data = emp };
    }
    public async Task<ServiceResponse<bool>> Delete(int Id)
    {
        var Delete = await _context.EmployeeMasters.FindAsync(Id);
        if (Delete == null)
        {
            return new ServiceResponse<bool>
            {
                Success = false,
                Data = false,
                Message = "Data not found."
            };
        }
        await _context.SaveChangesAsync();
        return new ServiceResponse<bool> { Data = true };
    }
    public async Task<ServiceResponse<List<EmployeeMaster>>> GetAll()
    {
        var response = new ServiceResponse<List<EmployeeMaster>>
        {
            Data = await _context.EmployeeMasters.Include("DesignationMaster").AsNoTracking().ToListAsync()
        };
        return response;
    }
    public async Task<ServiceResponse<EmployeeMaster>> GetById(int Id)
    {
        var response = new ServiceResponse<EmployeeMaster>();
        EmployeeMaster? emp = null;
        emp = await _context.EmployeeMasters.FirstOrDefaultAsync(p => p.Empno == Id);

        if (emp == null)
        {
            response.Success = false;
            response.Message = "Sorry, but this data does not exist.";
        }
        else
        {
            response.Data = emp;
        }
        return response;
    }
    public async Task<bool> IsAuthorized(string Username, string Password)
    {
        bool Auth = false;

        var k = await _context.EmployeeMasters.Where(temp => temp.Firstname == Username && temp.Password == Password).ToListAsync();
        if (k.Count > 0)
        {
            Auth = true;
        }
        else
        {
            Auth = false;
        }
        return Auth;
    }  
    public async Task<ServiceResponse<EmployeeMaster>> Update(EmployeeMaster emp)
    {
        var Update = await _context.EmployeeMasters.FirstOrDefaultAsync(p => p.Empno == emp.Empno);

        if (Update == null)
        {
            return new ServiceResponse<EmployeeMaster>
            {
                Success = false,
                Message = "Data not found."
            };
        }
        Update.Firstname = emp.Firstname;
        Update.LastName = emp.LastName;
        Update.AliasName = emp.AliasName;
        await _context.SaveChangesAsync();
        return new ServiceResponse<EmployeeMaster> { Data = emp };
    }
    private async Task<List<EmployeeMaster>> FindUserBySearchText(string searchText)
    {
        return await _context.EmployeeMasters.Where(temp => temp.AliasName!.ToLower().Contains(searchText.ToLower())).ToListAsync();
    }
    public async Task<ServiceResponse<List<EmployeeMaster>>> SearchUser(string searchText)
    {
        var response = new ServiceResponse<List<EmployeeMaster>>
        {
            Data = await FindUserBySearchText(searchText)
        };
        return response;
    }
    public async Task<ServiceResponse<List<string>>> GetUserSearchSuggestions(string searchText)
    {
        var users = await FindUserBySearchText(searchText);
        List<string> result = new List<string>();
        foreach (var user in users)
        {
            if (user.AliasName!.Contains(searchText, StringComparison.OrdinalIgnoreCase))
            {
                result.Add(user.AliasName);
            }
        }
        return new ServiceResponse<List<string>> { Data = result };
    }

}
