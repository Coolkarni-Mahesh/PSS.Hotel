using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class RawItemIssuedetail
{
    public int? IssueId { get; set; }

    public int? Srno { get; set; }

    public int? RawitemId { get; set; }

    public float? Qty { get; set; }

    public float? Rate { get; set; }
}
