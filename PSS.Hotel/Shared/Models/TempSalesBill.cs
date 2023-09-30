using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TempSalesBill
{
    public int? Salesbillno { get; set; }

    public int? ActualBill { get; set; }

    public float? FoodAmt { get; set; }

    public float? LiquerAmt { get; set; }

    public float? Discount { get; set; }

    public float? NetAmt { get; set; }
}
