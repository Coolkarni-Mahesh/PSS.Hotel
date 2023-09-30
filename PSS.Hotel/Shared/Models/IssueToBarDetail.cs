using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class IssueToBarDetail
{
    public int? IssueId { get; set; }

    public int? Srno { get; set; }

    public int? RawitemId { get; set; }

    public int? Unitcode { get; set; }

    public float? Qty { get; set; }
}
