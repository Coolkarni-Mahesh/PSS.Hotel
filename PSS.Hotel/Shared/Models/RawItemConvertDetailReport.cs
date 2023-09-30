using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class RawItemConvertDetailReport
{
    public int? TransactionId { get; set; }

    public string? RawItem { get; set; }

    public string? Unit { get; set; }

    public float? ConversitionQty { get; set; }

    public int? BarCounterId { get; set; }
}
