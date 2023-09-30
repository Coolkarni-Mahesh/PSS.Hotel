using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ItemWiseConsumption
{
    public string? RawItem { get; set; }

    public int? RawItemId { get; set; }

    public string? Unit { get; set; }

    public int? Unitcode { get; set; }

    public int? Ml { get; set; }

    public double? PurQty { get; set; }

    public double? PurRtnQty { get; set; }

    public double? Issue { get; set; }

    public double? Return { get; set; }

    public double? Wastage { get; set; }

    public double? Sale { get; set; }

    public double? ConvertToLoose { get; set; }
}
