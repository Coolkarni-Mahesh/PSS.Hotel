using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ItemwiseSalesQtyReport
{
    public string? BillType { get; set; }

    public string? ItemName { get; set; }

    public int? ItemCode { get; set; }

    public int? UnitCode { get; set; }

    public string? Unit { get; set; }

    public float? OrderQty { get; set; }

    public float? CancelQty { get; set; }

    public int? SaleQty { get; set; }

    public int? Sales { get; set; }

    public string? GroupName { get; set; }

    public string? SubGroup { get; set; }

    public DateTime? Tdate { get; set; }
}
