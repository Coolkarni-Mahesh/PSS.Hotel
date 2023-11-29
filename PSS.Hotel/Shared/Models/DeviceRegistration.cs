using System.ComponentModel.DataAnnotations;

namespace PSS.Hotel.Shared.Models;

public class DeviceRegistration
{
    [Key]
    public int Id { get; set; }
    [StringLength(50)]
    [Required(ErrorMessage ="* Username is required")]
    public string? Username { get; set; }
    [StringLength(50)]
    [Required(ErrorMessage = "* Server IP Address is required")]
    public string? ServerIPAddress { get; set; }
    [StringLength(50)]
    public string? UserDeviceNo { get; set;}
    public DateTime RegistrationDate { get; set; } = DateTime.Now;       
}
