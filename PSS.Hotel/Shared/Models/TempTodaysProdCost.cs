using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TempTodaysProdCost
{
    public int? Itemcode { get; set; }

    public string? ItemName { get; set; }

    public int? Qty { get; set; }

    public float? PurchasePrice { get; set; }

    public float? Amount { get; set; }
}
