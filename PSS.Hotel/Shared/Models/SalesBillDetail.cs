using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class SalesBillDetail
{
    public int? Pbillcode { get; set; }

    public int? Srno { get; set; }

    public string? Billtype { get; set; }

    public int? Itemcode { get; set; }

    public int? Unitcode { get; set; }

    public float? Order { get; set; }

    public float? Rate { get; set; }

    public float? SnacksRate { get; set; }

    public int? ConvertUnitCode { get; set; }

    public float? ActualRate { get; set; }

    public DateTime? Tdate { get; set; }

    public float? Gstrate { get; set; }

    public string? Kotmsg { get; set; }
}
