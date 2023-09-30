using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TempDeptWiseCounterCashier
{
    public string? DepertmentName { get; set; }

    public DateTime? Tdate { get; set; }

    public float? Sales { get; set; }

    public float? Credit { get; set; }

    public float? Expense { get; set; }

    public float? Deposit { get; set; }
}
