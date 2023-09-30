using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class StockConsumptionReport
{
    public string? RawItem { get; set; }

    public string? Unit { get; set; }

    public float? Opening { get; set; }

    public float? Receipt { get; set; }

    public float? Convertd { get; set; }

    public double? Total { get; set; }

    public float? Asales { get; set; }

    public float? Csales { get; set; }

    public double? Dsales { get; set; }

    public double? Closing { get; set; }
}
