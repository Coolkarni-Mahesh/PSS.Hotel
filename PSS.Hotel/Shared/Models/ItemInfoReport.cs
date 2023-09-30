using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ItemInfoReport
{
    public int? Itemid { get; set; }

    public string? Itemname { get; set; }

    public string? Unit { get; set; }

    public short? Itemgroupcode { get; set; }

    public float? Salesprice { get; set; }

    public float? Snacks { get; set; }

    public string? SubGroup { get; set; }
}
