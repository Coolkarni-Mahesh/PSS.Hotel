using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CounCasessIiexpensesReport
{
    public int? TransactionId { get; set; }

    public int? RawitemId { get; set; }

    public string? RawItem { get; set; }

    public int? ExpensesId { get; set; }

    public string? Expenses { get; set; }

    public int? Unitcode { get; set; }

    public string? Unit { get; set; }

    public int? SrNo { get; set; }

    public string? Type { get; set; }

    public float? Qty { get; set; }

    public float? Free { get; set; }

    public float? Rate { get; set; }

    public DateTime? Tdate { get; set; }
}
