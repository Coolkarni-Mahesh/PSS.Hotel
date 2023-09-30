using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TempStockConsumption
{
    public int? RawitemId { get; set; }

    public int? Unitcode { get; set; }

    public float? Opening { get; set; }

    public float? Receipt { get; set; }

    public float? Convertd { get; set; }

    public float? Asales { get; set; }

    public float? Csales { get; set; }

    public float? LiquerRate { get; set; }

    public float? SnacksRate { get; set; }

    public float? PurchaseRate { get; set; }

    public int? Section1Qty { get; set; }

    public float? Sec1LiquorRate { get; set; }

    public float? Sec1SnacksRate { get; set; }

    public int? Section2Qty { get; set; }

    public float? Sec2LiquorRate { get; set; }

    public float? Sec2SnacksRate { get; set; }

    public int? Section3Qty { get; set; }

    public float? Sec3LiquorRate { get; set; }

    public float? Sec3SnacksRate { get; set; }

    public int? Section4Qty { get; set; }

    public float? Sec4LiquorRate { get; set; }

    public float? Sec4SnacksRate { get; set; }
}
