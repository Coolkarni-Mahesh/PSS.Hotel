using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class PurchaseReturnDetail
{
    public int? Prcode { get; set; }

    public int? Srno { get; set; }

    public int? RawitemId { get; set; }

    public int? Unitcode { get; set; }

    public float? Qty { get; set; }

    public float? Rate { get; set; }

    public float? Discount { get; set; }
}
