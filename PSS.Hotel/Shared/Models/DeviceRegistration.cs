using System.ComponentModel.DataAnnotations;

namespace PSS.Hotel.Shared.Models;

public class DeviceRegistration
{
    [Key]
    public int Id { get; set; }
    [StringLength(50)]
    public string? Username { get; set; }
    [StringLength(50)]
    public string? ServerIPAddress { get; set; }
    [StringLength(50)]
    public string? UserDeviceNo { get; set;}
    public DateTime RegistrationDate { get; set; } = DateTime.Now;       
}
