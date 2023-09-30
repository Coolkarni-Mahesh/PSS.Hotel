using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class DeviceMaster
{
    public int? DeviceId { get; set; }

    public string? DeviceName { get; set; }

    public string? UpdateFlag { get; set; }

    public string? DeleteFlag { get; set; }
}
