using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TempOpeningStockDetail
{
    public int? RawitemId { get; set; }

    public int? Unitcode { get; set; }

    public float? Qty { get; set; }

    public float? CaseQty { get; set; }

    public float? BottleQty { get; set; }

    public string? BatchNo { get; set; }

    public float? UnitCaseQty { get; set; }

    public float? LooseQty { get; set; }

    public DateTime? BeerMfgdate { get; set; }

    public float? Mrp { get; set; }
}
