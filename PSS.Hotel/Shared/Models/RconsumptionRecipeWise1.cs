using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class RconsumptionRecipeWise1
{
    public DateTime? Tdate { get; set; }

    public string? RawItem { get; set; }

    public string? Unit { get; set; }

    public double? Qty { get; set; }

    public double? Amount { get; set; }
}
