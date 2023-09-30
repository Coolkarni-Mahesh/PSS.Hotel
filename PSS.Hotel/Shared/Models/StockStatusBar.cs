using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class StockStatusBar
{
    public int? RawitemId { get; set; }

    public int? Unitcode { get; set; }

    public float? Qty { get; set; }

    public int? BarCounterId { get; set; }
}
