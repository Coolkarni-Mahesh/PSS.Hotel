using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class LiquerCosting
{
    public DateTime? Tdate { get; set; }

    public string? ItemName { get; set; }

    public float? Qty { get; set; }

    public float? SalesValue { get; set; }

    public float? PurchaseValue { get; set; }

    public float? Menuvalue { get; set; }

    public int? ItemCode { get; set; }

    public int? Unitcode { get; set; }
}
