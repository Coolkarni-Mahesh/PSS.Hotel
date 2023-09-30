using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ExciseSummaryReport
{
    public DateTime? Tdate { get; set; }

    public int? BillNo { get; set; }

    public float? Liquor { get; set; }

    public float? Snacks { get; set; }

    public float? BasicAmount { get; set; }

    public float? VatAmt { get; set; }

    public float? ServiceChargeAmt { get; set; }

    public float? ServiceTaxAmt { get; set; }

    public float? RoundOff { get; set; }

    public float? Discount { get; set; }
}
