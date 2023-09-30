using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ItemWisePurchasedetail
{
    public int? Pbillcode { get; set; }

    public DateTime? Pdate { get; set; }

    public string? RawItem { get; set; }

    public string? Unit { get; set; }

    public float? Qty { get; set; }

    public double? Rate { get; set; }

    public float? Free { get; set; }

    public string? SubGroup { get; set; }

    public string? Name { get; set; }

    public int? OpeningFlag { get; set; }
}
