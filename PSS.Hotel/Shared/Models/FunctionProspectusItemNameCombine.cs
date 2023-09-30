using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class FunctionProspectusItemNameCombine
{
    public int? TransactionId { get; set; }

    public int? SrnoMain { get; set; }

    public int? SrNo { get; set; }

    public string? GroupName { get; set; }

    public string? ItemName { get; set; }

    public float? Qty { get; set; }

    public float? Rate { get; set; }
}
