using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CasessExpensessDetail
{
    public DateTime? Tdate { get; set; }

    public string? Expenses { get; set; }

    public string? RawItem { get; set; }

    public string? Unit { get; set; }

    public int? SrNo { get; set; }

    public string? Type { get; set; }

    public float? Qty { get; set; }

    public float? Free { get; set; }

    public float? Rate { get; set; }

    public string? ItemDescription { get; set; }

    public string? EgroupName { get; set; }

    public string? GroupName { get; set; }
}
