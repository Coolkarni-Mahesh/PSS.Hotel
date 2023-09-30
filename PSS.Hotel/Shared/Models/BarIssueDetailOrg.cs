using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class BarIssueDetailOrg
{
    public int? IssueId { get; set; }

    public DateTime? Idate { get; set; }

    public string? RawItem { get; set; }

    public int? Unitcode { get; set; }

    public string? Unit { get; set; }

    public int? BarCounterId { get; set; }

    public string? BarCounterName { get; set; }

    public float? Qty { get; set; }
}
