using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TodaySalesReportTemp
{
    public int? Itemcode { get; set; }

    public DateTime? Tdate { get; set; }

    public string? GroupName { get; set; }

    public int? ItemId { get; set; }

    public int? SalesQty { get; set; }

    public int? SalesPrice { get; set; }

    public string? SubGroup { get; set; }

    public int? SnacksPrice { get; set; }

    public string? ItemName { get; set; }

    public int? Rawitemcode { get; set; }

    public int? RoundOff { get; set; }

    public int? Unitcode { get; set; }

    public string? Unit { get; set; }

    public int? Amount { get; set; }
}
