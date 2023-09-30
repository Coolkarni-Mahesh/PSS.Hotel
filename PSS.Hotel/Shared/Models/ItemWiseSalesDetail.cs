using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ItemWiseSalesDetail
{
    public DateTime? Tdate { get; set; }

    public string? BillType { get; set; }

    public int? Itemcode { get; set; }

    public int? Unitcode { get; set; }

    public string? Unit { get; set; }

    public double? SumOfOrder { get; set; }

    public double? Amount { get; set; }

    public string? ItemName { get; set; }

    public string? GroupName { get; set; }
}
