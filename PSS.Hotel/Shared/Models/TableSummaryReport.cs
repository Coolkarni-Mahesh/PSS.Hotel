using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TableSummaryReport
{
    public DateTime? TransactionDate { get; set; }

    public string? TableName { get; set; }

    public int? NoOfTime { get; set; }

    public float? Amount { get; set; }
}
