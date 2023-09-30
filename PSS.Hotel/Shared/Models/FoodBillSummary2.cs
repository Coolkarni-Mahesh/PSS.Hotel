using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class FoodBillSummary2
{
    public int? Pbillcode { get; set; }

    public DateTime? Tdate { get; set; }

    public int? Order { get; set; }

    public int? Rate { get; set; }

    public double? Discount { get; set; }

    public double? RoundOff { get; set; }

    public int? FserviceTax { get; set; }
}
