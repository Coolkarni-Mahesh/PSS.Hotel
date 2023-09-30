using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class IssueDetail
{
    public int? RawItemId { get; set; }

    public int? UnitCode { get; set; }

    public int? IssueId { get; set; }

    public DateTime? Idate { get; set; }

    public string? RawItem { get; set; }

    public string? Unit { get; set; }

    public float? Qty { get; set; }

    public float? Rate { get; set; }

    public string? Department { get; set; }
}
