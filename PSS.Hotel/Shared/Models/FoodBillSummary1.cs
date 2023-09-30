using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class FoodBillSummary1
{
    public int? Pbillno { get; set; }

    public int? TaxableAmt { get; set; }

    public float? Gstamt { get; set; }

    public float? AddLess { get; set; }

    public int? NetAmt { get; set; }

    public DateTime? Tdate { get; set; }

    public string? Remark { get; set; }
}
