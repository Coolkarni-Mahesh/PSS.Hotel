using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CasessOtherDeposit
{
    public int? Srno { get; set; }

    public DateTime? Tdate { get; set; }

    public int? DepositorId { get; set; }

    public string? DepositorName { get; set; }

    public float? Amount { get; set; }
}
