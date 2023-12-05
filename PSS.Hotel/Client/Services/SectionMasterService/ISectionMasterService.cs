namespace PSS.Hotel.Client.Services.SectionMasterService;

public interface ISectionMasterService
{
    List<SectionMaster> Sections { get; set; }
    Task GetAll();
}
