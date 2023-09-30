using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class FoodAdjustment
{
    public int? PbillCode { get; set; }

    public int? Itemcode { get; set; }

    public float? Order { get; set; }

    public float? Rate { get; set; }
}
