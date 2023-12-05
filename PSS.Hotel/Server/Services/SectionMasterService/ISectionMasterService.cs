namespace PSS.Hotel.Server.Services.SectionMasterService;

public interface ISectionMasterService
{
    Task<ServiceResponse<List<SectionMaster>>> GetAll();
}
