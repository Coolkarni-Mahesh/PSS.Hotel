using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ItemLiquer
{
    public int? Itemcode { get; set; }

    public int? Unitcode { get; set; }

    public float? Qty { get; set; }

    public float? Liquer { get; set; }

    public float? Snacks { get; set; }

    public int? ConvertUnitCode { get; set; }
}
