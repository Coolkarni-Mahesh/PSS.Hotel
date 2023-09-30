using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ShiftMaster
{
    public int? ShiftId { get; set; }

    public string? ShiftName { get; set; }

    public DateTime? FstartTime { get; set; }

    public DateTime? FendTime { get; set; }

    public DateTime? SstartTime { get; set; }

    public DateTime? SendTime { get; set; }

    public string? DeleteFlag { get; set; }
}
