using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TodaySalesReport
{
    public int? Itemcode { get; set; }

    public DateTime? Tdate { get; set; }

    public string? GroupName { get; set; }

    public string? ItemId { get; set; }

    public float? SalesQty { get; set; }

    public float? SalesPrice { get; set; }

    public string? SubGroup { get; set; }

    public float? SnacksPrice { get; set; }

    public string? ItemName { get; set; }

    public int? Rawitemcode { get; set; }

    public int? RoundOff { get; set; }

    public string? Unit { get; set; }
}
