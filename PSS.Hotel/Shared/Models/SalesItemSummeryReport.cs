using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class SalesItemSummeryReport
{
    public DateTime? Tdate { get; set; }

    public string? ItemId { get; set; }

    public string? ItemName { get; set; }

    public string? Unit { get; set; }

    public double? OrderQty { get; set; }

    public float? Rate { get; set; }

    public int? ItemGroupCode { get; set; }
}
