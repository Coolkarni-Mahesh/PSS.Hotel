using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class StockConsumption
{
    public int? TransactionId { get; set; }

    public DateTime? Tdate { get; set; }

    public string? Remark { get; set; }

    public int? BarCounterId { get; set; }
}
