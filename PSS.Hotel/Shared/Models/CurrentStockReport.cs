using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CurrentStockReport
{
    public int? RawitemId { get; set; }

    public string? GroupName { get; set; }

    public string? RawItem { get; set; }

    public string? Unit { get; set; }

    public float? Qty { get; set; }

    public float? Rate { get; set; }

    public float? Bar2Qty { get; set; }

    public float? Bar3Qty { get; set; }

    public float? Bar4Qty { get; set; }
}
