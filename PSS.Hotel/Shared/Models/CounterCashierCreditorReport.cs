using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CounterCashierCreditorReport
{
    public string? CreditName { get; set; }

    public double? Amt { get; set; }

    public DateTime? Tdate { get; set; }

    public string? Name { get; set; }

    public string? BillId { get; set; }

    public string? Lodgin { get; set; }

    public string? Remark { get; set; }
}
