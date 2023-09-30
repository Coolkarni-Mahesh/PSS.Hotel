using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class DailyTableCd
{
    public int? TableId { get; set; }

    public string? CustomerName { get; set; }

    public int? Empno { get; set; }

    public int? Pax { get; set; }

    public double? BasicAmount { get; set; }

    public double? TaxAmount { get; set; }

    public double? NetAmount { get; set; }
}
