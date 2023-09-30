using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class SalesBillDetailDaily
{
    public int? TransNo { get; set; }

    public int? Pbillcode { get; set; }

    public DateTime? Tdate { get; set; }

    public string? BillType { get; set; }

    public int? Itemcode { get; set; }

    public int? Unitcode { get; set; }

    public float? Order { get; set; }

    public float? Cancel { get; set; }

    public float? Rate { get; set; }

    public float? SnacksRate { get; set; }

    public string? Kotbot { get; set; }

    public int? KotNo { get; set; }

    public float? ActualRate { get; set; }

    public float? Gstrate { get; set; }

    public string? Kotmsg { get; set; }
}
