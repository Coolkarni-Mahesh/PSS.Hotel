using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class FoodDataGroupingTemp
{
    public int? Srno { get; set; }

    public int? PbillCode { get; set; }

    public int? Itemcode { get; set; }

    public float? Order { get; set; }

    public float? Rate { get; set; }

    public float? Discount { get; set; }

    public int? LiquorPbillcode { get; set; }

    public float? LiquorBillamt { get; set; }
}
