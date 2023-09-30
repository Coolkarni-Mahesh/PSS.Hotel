using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class RconsumptionRecipeWise
{
    public DateTime? Tdate { get; set; }

    public string? RawItem { get; set; }

    public string? Unit { get; set; }

    public float? Qty { get; set; }

    public double? Amount { get; set; }

    public int? DepartmentCode { get; set; }

    public string? Department { get; set; }
}
