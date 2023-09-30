using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TotalLiquorConsumption
{
    public int? ItemCode { get; set; }

    public string? RawItem { get; set; }

    public string UnitName { get; set; } = null!;

    public int? TotalQty { get; set; }
}
