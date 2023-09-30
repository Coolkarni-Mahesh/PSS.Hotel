using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TempIssueToBarDetail
{
    public int? IssueId { get; set; }

    public DateTime? Idate { get; set; }

    public string? RawItem { get; set; }

    public int? UnitCode { get; set; }

    public string? Unit { get; set; }

    public int? BarCounterId { get; set; }

    public string? BarCounterName { get; set; }

    public int? Bar1Qty { get; set; }

    public int? Bar2Qty { get; set; }

    public int? Bar3Qty { get; set; }

    public int? Bar4Qty { get; set; }
}
