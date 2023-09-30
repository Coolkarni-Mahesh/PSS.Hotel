using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TempPurchaseRate
{
    public int? RawitemId { get; set; }

    public int? Unitcode { get; set; }

    public float? Rate { get; set; }
}
