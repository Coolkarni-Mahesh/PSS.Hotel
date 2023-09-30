using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class MsummeryReport
{
    public DateTime? Cmonth { get; set; }

    public float? PurchaseAmt { get; set; }

    public float? PurchaseBalanceAmt { get; set; }

    public float? ExpensesAmt { get; set; }

    public int? SalesAmt { get; set; }

    public int? SalesBalanceAmt { get; set; }
}
