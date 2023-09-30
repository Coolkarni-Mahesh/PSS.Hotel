using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CounCasess2Expense
{
    public int? TransactionId { get; set; }

    public int? RawitemId { get; set; }

    public int? ExpensesId { get; set; }

    public int? Unitcode { get; set; }

    public int? SrNo { get; set; }

    public string? Type { get; set; }

    public float? Qty { get; set; }

    public float? Free { get; set; }

    public float? Rate { get; set; }
}
