using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class BillSummary2
{
    public int? Holdno { get; set; }

    public int? FoodBillNo { get; set; }

    public float? FoodBillAmt { get; set; }

    public int? LiquerBillNo { get; set; }

    public float? LiquerBillAmt { get; set; }

    public DateTime? Tdate { get; set; }

    public int? Discount { get; set; }

    public int? Credit { get; set; }
}
