using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TempStockConsumptionDetail
{
    public int? RawitemId { get; set; }

    public int? Unitcode { get; set; }

    public float? Opening { get; set; }

    public float? Receipt { get; set; }

    public float? Convertd { get; set; }

    public float? Asales { get; set; }

    public float? Csales { get; set; }

    public int? Section1Qty { get; set; }

    public int? Section2Qty { get; set; }

    public int? Section3Qty { get; set; }

    public int? Section4Qty { get; set; }
}
