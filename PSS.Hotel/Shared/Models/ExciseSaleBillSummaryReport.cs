using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ExciseSaleBillSummaryReport
{
    public int? Pbillcode { get; set; }

    public double? Amount { get; set; }

    public DateTime? Tdate { get; set; }

    public float? LvatAmount { get; set; }

    public float? LserviceChargeAmt { get; set; }

    public float? RoundOff { get; set; }

    public float? LserviceTaxAmt { get; set; }
}
