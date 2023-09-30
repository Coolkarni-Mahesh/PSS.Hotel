using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ItemDapartmentwiseDailySale
{
    public string? Department { get; set; }

    public int? ItemCode { get; set; }

    public int? UnitCode { get; set; }

    public int? SaleQty { get; set; }

    public int? Rate { get; set; }
}
