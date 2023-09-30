using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TodaySalesItemWiseCaptain
{
    public int? Itemcode { get; set; }

    public int? Unitcode { get; set; }

    public float? SalesQty { get; set; }

    public float? SalesPrice { get; set; }

    public float? SnacksPrice { get; set; }

    public DateTime? Tdate { get; set; }

    public string? ItemName { get; set; }

    public int? RoundOff { get; set; }

    public int? CaptainCode { get; set; }

    public string? CaptainName { get; set; }
}
