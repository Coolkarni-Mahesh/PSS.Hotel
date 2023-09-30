using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TempItemGroupWiseDailySale
{
    public int? ItemGroupCode { get; set; }

    public string? GroupName { get; set; }

    public int? ItemCode { get; set; }

    public int? UnitCode { get; set; }

    public int? SaleQty { get; set; }

    public float? Rate { get; set; }
}
