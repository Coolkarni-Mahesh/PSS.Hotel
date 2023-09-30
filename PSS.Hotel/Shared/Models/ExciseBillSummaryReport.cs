using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ExciseBillSummaryReport
{
    public string? ExciseType { get; set; }

    public DateTime? Tdate { get; set; }

    public double? Mrp { get; set; }

    public string? BillNo { get; set; }
}
