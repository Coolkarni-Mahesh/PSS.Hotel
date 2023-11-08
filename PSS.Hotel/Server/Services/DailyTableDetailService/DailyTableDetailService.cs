using Microsoft.EntityFrameworkCore;
using PSS.Hotel.Shared.Models;
using System.ComponentModel.DataAnnotations.Schema;

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

    public async Task<ServiceResponse<DailyTableDetail>> GetByID(int ID)
    {
        try
        {
            var response = new ServiceResponse<DailyTableDetail>()
            {
                Data = await _context.DailyTableDetails.Include("itemMaster").Where(temp => temp.DailyTableDetailId == ID).AsNoTracking().FirstOrDefaultAsync()
            };
            return response;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<ServiceResponse<List<DailyTableDetail>>> GetByKotNo(int KotNo)
    {
        try
        {
            var response = new ServiceResponse<List<DailyTableDetail>>()
            {
                Data = await _context.DailyTableDetails.Include("itemMaster").Where(temp => temp.KotNo == KotNo).AsNoTracking().ToListAsync()
            };
            return response;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<ServiceResponse<DailyTableDetail>> Update(DailyTableDetail dailyTableDetail)
    {

        try
        {

            var Update = await _context.DailyTableDetails.Include(temp => temp.itemMaster).FirstOrDefaultAsync(temp => temp.DailyTableDetailId == dailyTableDetail.DailyTableDetailId);

            if (Update == null)
            {
                return new ServiceResponse<DailyTableDetail>
                {
                    Success = false,
                    Message = "Item not found."
                };
            }

            //     Update.DailyTableDetailID = dailyTableDetail.DailyTableDetailID;
            //Update.Srno = dailyTableDetail.Srno;
            //Update.TableNo = dailyTableDetail.TableNo;
            //Update.Order = dailyTableDetail.Order;
            //Update.Unitcode = dailyTableDetail.Unitcode;
            //Update.Rate = dailyTableDetail.Rate;
            //Update.SnacksRate = dailyTableDetail.SnacksRate;
            //Update.Kotbot = dailyTableDetail.Kotbot;
            //Update.KotNo = dailyTableDetail.KotNo;
            //Update.Stockded = dailyTableDetail.Stockded;
            //Update.ActualRate = dailyTableDetail.ActualRate;
            //Update.StartTime = dailyTableDetail.StartTime;
            //Update.Kotmsg = dailyTableDetail.Kotmsg;
            Update.Pending = dailyTableDetail.Pending;
            Update.Ready = dailyTableDetail.Ready;
            Update.Delivered = dailyTableDetail.Delivered;
            Update.Cooking = dailyTableDetail.Cooking;
            Update.Cancel = dailyTableDetail.Cancel;

            //   Update.itemMaster.Itemcode= dailyTableDetail.itemMaster.Itemcode;

            //Update.itemMaster.ItemId = dailyTableDetail.itemMaster.ItemId;

            //Update.itemMaster.UseId = dailyTableDetail.itemMaster.UseId;

            //Update.itemMaster.DepartmentCode = dailyTableDetail.itemMaster.DepartmentCode;

            //Update.itemMaster.Rawitemcode = dailyTableDetail.itemMaster.Rawitemcode;

            //Update.itemMaster.ItemGroupCode = dailyTableDetail.itemMaster.ItemGroupCode;

            //Update.itemMaster.ItemName = dailyTableDetail.itemMaster.ItemName;

            //Update.itemMaster.Unitcode = dailyTableDetail.itemMaster.Itemcode;

            //Update.itemMaster.SalesPrice = dailyTableDetail.itemMaster.SalesPrice;

            //Update.itemMaster.PurchasePrice = dailyTableDetail.itemMaster.PurchasePrice;

            //Update.itemMaster.Description =dailyTableDetail.itemMaster.Description;

            //Update.itemMaster.Deleteflag = dailyTableDetail.itemMaster.Deleteflag;

            //Update.itemMaster.ExciseGroupId = dailyTableDetail.itemMaster.ExciseGroupId;

            //Update.itemMaster.LiquorTypeId = dailyTableDetail.itemMaster.LiquorTypeId;

            //Update.itemMaster.BeerExpiryDays = dailyTableDetail.itemMaster.BeerExpiryDays;

            //Update.itemMaster.ItemAllowMachine = dailyTableDetail.itemMaster.ItemAllowMachine;

            //Update.itemMaster.ItemShortName = dailyTableDetail.itemMaster.ItemShortName;

            //Update.itemMaster.CpgroupCode = dailyTableDetail.itemMaster.CpgroupCode;

            //Update.itemMaster.Tdate = dailyTableDetail.itemMaster.Tdate;

            //Update.itemMaster.TsmainGroupcode = dailyTableDetail.itemMaster.TsmainGroupcode;

            //Update.itemMaster.TssubGroupcode = dailyTableDetail.itemMaster.TssubGroupcode;

            //Update.itemMaster.ItemImagePath = dailyTableDetail.itemMaster.ItemImagePath;


            //_context.Entry(Update).State = EntityState.Modified;

            int k = await _context.SaveChangesAsync();

            return new ServiceResponse<DailyTableDetail>
            {
                Data = Update
            };

        }
        catch (Exception)
        {
            throw;

        }

    }
}
