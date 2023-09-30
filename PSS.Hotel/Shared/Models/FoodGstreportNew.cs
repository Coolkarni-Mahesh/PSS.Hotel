using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class FoodGstreportNew
{
    public int? Pbillcode { get; set; }

    public DateTime? Tdate { get; set; }

    public string? BillType { get; set; }

    public int? Customercode { get; set; }

    public string? Gst { get; set; }

    public float? FserviceTax { get; set; }

    public float? FserviceTaxAmt { get; set; }

    public float? Discount { get; set; }

    public string? CustName { get; set; }

    public float? Billamt { get; set; }

    public double? Order1 { get; set; }

    public double? Rate { get; set; }

    public float? RoundOff { get; set; }
}
