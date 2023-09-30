using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class SectionWiseSale
{
    public string? SectionName { get; set; }

    public string? SubGroup { get; set; }

    public int? ItemCode { get; set; }

    public int? UnitCode { get; set; }

    public int? SaleQty { get; set; }

    public int? Rate { get; set; }
}
