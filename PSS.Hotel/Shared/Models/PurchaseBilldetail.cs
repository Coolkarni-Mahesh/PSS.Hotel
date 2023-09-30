using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class PurchaseBilldetail
{
    public int? Pbillcode { get; set; }

    public int? Srno { get; set; }

    public int? RawitemId { get; set; }

    public int? Unitcode { get; set; }

    public float? Qty { get; set; }

    public float? Rate { get; set; }

    public float? Free { get; set; }

    public float? CaseQty { get; set; }

    public float? BottleQty { get; set; }

    public float? Mrp { get; set; }

    public string? BatchNo { get; set; }

    public float? UnitCaseQty { get; set; }

    public int? OpeningUnitCode { get; set; }

    public DateTime? BeerMfgdate { get; set; }

    public int? Gsttax { get; set; }
}
