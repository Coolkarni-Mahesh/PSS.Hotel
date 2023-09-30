using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TempStockVarifaction
{
    public int? RawitemId { get; set; }

    public int? Unitcode { get; set; }

    public float? CurrPackQty { get; set; }

    public float? CurrLooseQty { get; set; }

    public float? ExcisePackQty { get; set; }

    public float? ExciseLooseQty { get; set; }

    public float? RclooseBalQty { get; set; }
}
