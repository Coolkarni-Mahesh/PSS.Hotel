using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class StockVarifactionLooseReport
{
    public int? RawitemId { get; set; }

    public string? RawItem { get; set; }

    public int? Unitcode { get; set; }

    public string? Unit { get; set; }

    public float? Ml { get; set; }

    public string? LiquorType { get; set; }

    public float? TotalConvert { get; set; }

    public float? ActualBalMl { get; set; }

    public float? SalesLoose { get; set; }

    public float? ExciseBalSales { get; set; }

    public float? CurrentStockLoose { get; set; }
}
