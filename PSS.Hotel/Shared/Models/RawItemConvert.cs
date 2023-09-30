using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class RawItemConvert
{
    public int? TransactionId { get; set; }

    public int? RawitemId { get; set; }

    public int? FromUnitcode { get; set; }

    public float? ConversitionQty { get; set; }

    public int? ExBalanceQty { get; set; }

    public int? BarCounterId { get; set; }

    public float? ExBalanceMl { get; set; }
}
