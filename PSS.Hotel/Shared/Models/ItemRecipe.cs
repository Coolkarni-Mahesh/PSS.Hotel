using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ItemRecipe
{
    public short? Itemcode { get; set; }

    public short? Rawitemid { get; set; }

    public short? Srno { get; set; }

    public float? Qty { get; set; }

    public float? Rate { get; set; }

    public float? Amount { get; set; }

    public int? UnitCode { get; set; }
}
