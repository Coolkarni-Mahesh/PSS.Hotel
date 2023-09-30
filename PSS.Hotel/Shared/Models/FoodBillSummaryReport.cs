using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class FoodBillSummaryReport
{
    public int? Pbillcode { get; set; }

    public DateTime? Tdate { get; set; }

    public string? BillType { get; set; }

    public float? Discount { get; set; }

    public float? Fvat { get; set; }

    public float? FvatAmount { get; set; }

    public float? FserviceCharge { get; set; }

    public float? FserviceChargeAmt { get; set; }

    public float? FserviceTax { get; set; }

    public float? FserviceTaxAmt { get; set; }

    public double? GrandAmount { get; set; }

    public string? Name { get; set; }

    public float? RoundOff { get; set; }

    public float? BillAmount { get; set; }

    public double? TotalAmt { get; set; }
}
