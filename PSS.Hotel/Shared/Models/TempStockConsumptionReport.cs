﻿using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TempStockConsumptionReport
{
    public int? RawitemId { get; set; }

    public int? Unitcode { get; set; }

    public float? Opening { get; set; }

    public float? Receipt { get; set; }

    public float? Convertd { get; set; }

    public float? Asales { get; set; }

    public float? Csales { get; set; }
}
