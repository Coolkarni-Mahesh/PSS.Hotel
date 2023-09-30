using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TempGrossProfit
{
    public int? Itemcode { get; set; }

    public string? ItemName { get; set; }

    public int? Qty { get; set; }

    public float? SalesPrice { get; set; }

    public float? Amount { get; set; }

    public DateTime? Tdate { get; set; }
}
