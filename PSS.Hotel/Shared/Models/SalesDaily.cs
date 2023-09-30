using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class SalesDaily
{
    public DateTime? Tdate { get; set; }

    public int? Itemcode { get; set; }

    public int? Unitcode { get; set; }

    public int? Qty { get; set; }

    public int? ReturnQty { get; set; }
}
