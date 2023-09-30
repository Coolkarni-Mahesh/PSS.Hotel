using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class FoodAdjustmentTemp
{
    public int? Srno { get; set; }

    public int? Pbillcode { get; set; }

    public DateTime? Tdate { get; set; }

    public string? BillType { get; set; }

    public int? Itemcode { get; set; }

    public float? Order { get; set; }

    public float? Rate { get; set; }

    public float? SnacksRate { get; set; }

    public int? SubGroupCode { get; set; }
}
