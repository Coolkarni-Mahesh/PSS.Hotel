using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TempItemWiseSalesWithMrprate
{
    public int? SubGroupcode { get; set; }

    public int? Itemcode { get; set; }

    public int? Unitcode { get; set; }

    public float? Order { get; set; }

    public float? PurchaseRate { get; set; }

    public string? SectionName { get; set; }
}
