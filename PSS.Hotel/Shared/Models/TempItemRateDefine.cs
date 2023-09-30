using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TempItemRateDefine
{
    public int? Pbillcode { get; set; }

    public int? Itemcode { get; set; }

    public int? Unitcode { get; set; }

    public float? Rate { get; set; }

    public float? SnacksRate { get; set; }
}
