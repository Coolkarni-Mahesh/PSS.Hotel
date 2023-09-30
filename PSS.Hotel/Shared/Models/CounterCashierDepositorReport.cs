using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CounterCashierDepositorReport
{
    public DateTime? Tdate { get; set; }

    public string? CashType { get; set; }

    public float? Amount { get; set; }

    public string? Name { get; set; }

    public string? Remark { get; set; }
}
