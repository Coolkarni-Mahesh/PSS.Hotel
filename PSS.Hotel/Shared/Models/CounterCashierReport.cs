using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CounterCashierReport
{
    public DateTime? Tdate { get; set; }

    public string? BillType { get; set; }

    public double? SumOfBillamt { get; set; }
}
