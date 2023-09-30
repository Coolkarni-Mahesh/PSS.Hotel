using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CounCasess2Depositor
{
    public int? TransactionId { get; set; }

    public int? Srno { get; set; }

    public int? Customercode { get; set; }

    public string? CashType { get; set; }

    public float? Amount { get; set; }
}
