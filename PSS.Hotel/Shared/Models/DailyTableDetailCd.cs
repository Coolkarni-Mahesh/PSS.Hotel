using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class DailyTableDetailCd
{
    public int? Srno { get; set; }

    public int? TableId { get; set; }

    public int? Itemcode { get; set; }

    public int? Order { get; set; }

    public int? Unitcode { get; set; }

    public float? Cancel { get; set; }

    public float? Rate { get; set; }

    public float? SnacksRate { get; set; }

    public string? TasteName { get; set; }
}
