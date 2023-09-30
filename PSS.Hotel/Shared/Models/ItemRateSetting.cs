using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ItemRateSetting
{
    public int? Itemcode { get; set; }

    public string? ItemType { get; set; }

    public int? Unitcode { get; set; }

    public float? FirstRate { get; set; }

    public float? SnackFirst { get; set; }

    public float? SecondRate { get; set; }

    public float? SnackSecond { get; set; }

    public string? RateUpdate { get; set; }

    public string? Deleteflag { get; set; }
}
