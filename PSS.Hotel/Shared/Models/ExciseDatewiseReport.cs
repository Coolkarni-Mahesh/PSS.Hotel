using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ExciseDatewiseReport
{
    public int? Srno { get; set; }

    public DateTime? Tdate { get; set; }

    public float? FoodAmt { get; set; }

    public float? LiquerAmt { get; set; }

    public float? SnacksAmt { get; set; }

    public float? Lodging { get; set; }
}
