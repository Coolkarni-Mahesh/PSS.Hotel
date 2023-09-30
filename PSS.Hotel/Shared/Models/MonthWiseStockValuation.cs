﻿using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class MonthWiseStockValuation
{
    public string? RawItem { get; set; }

    public string? Unit { get; set; }

    public float? Opening { get; set; }

    public float? Receipt { get; set; }

    public float? Closing { get; set; }

    public float? LiquerRate { get; set; }

    public float? SnacksRate { get; set; }

    public float? PurchaseRate { get; set; }

    public double? SalesRateAmount { get; set; }

    public float? Mrp { get; set; }
}
