using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class FoodGstreport
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
}
