using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CurrentStock
{
    public int? RawitemId { get; set; }

    public int? Unitcode { get; set; }

    public float? Qty { get; set; }

    public float? Rate { get; set; }

    public float? Bar2Qty { get; set; }

    public float? Bar3Qty { get; set; }

    public float? Bar4Qty { get; set; }
}
