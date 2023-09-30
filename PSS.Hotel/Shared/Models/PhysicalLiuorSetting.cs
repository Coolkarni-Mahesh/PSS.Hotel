using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class PhysicalLiuorSetting
{
    public int? RawitemId { get; set; }

    public string? RawItem { get; set; }

    public int? Unitcode { get; set; }

    public string? Unit { get; set; }

    public float? Opening { get; set; }

    public float? Receipt { get; set; }

    public float? Convertd { get; set; }

    public float? Asales { get; set; }

    public float? Csales { get; set; }

    public float? LiquerRate { get; set; }

    public float? SnacksRate { get; set; }

    public float? PurchaseRate { get; set; }
}
