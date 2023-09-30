using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ItemWiseSalesWithMrprateReport
{
    public string? SubGroup { get; set; }

    public string? ItemName { get; set; }

    public string? Unit { get; set; }

    public float? Order { get; set; }

    public float? PurchaseRate { get; set; }

    public string? SectionName { get; set; }
}
