using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CounCasess1OwnerDeposit
{
    public int? TransactionId { get; set; }

    public int? Srno { get; set; }

    public int? DepositorId { get; set; }

    public float? Amount { get; set; }

    public string? Remark { get; set; }
}
