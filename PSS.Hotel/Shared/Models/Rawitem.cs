using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class Rawitem
{
    public int? RawitemId { get; set; }

    public int? ItemGroupCode { get; set; }

    public string? RawItem1 { get; set; }

    public int? Unitcode { get; set; }

    public float? Rate { get; set; }

    public string? StockEffect { get; set; }

    public string? Deleteflag { get; set; }

    public int? ExciseGroupId { get; set; }

    public int? LiquorTypeId { get; set; }
}
