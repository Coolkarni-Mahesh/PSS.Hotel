using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class LiquorGroupWiseSale
{
    public string? GroupName { get; set; }

    public string? Unit { get; set; }

    public int? Qty { get; set; }

    public int? ItemCode { get; set; }

    public int? Unitcode { get; set; }
}
