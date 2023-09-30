using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ItemRateChangeReport
{
    public int? TransNo { get; set; }

    public string? BillType { get; set; }

    public int? Pbillcode { get; set; }

    public string? TableName { get; set; }

    public int? Customercode { get; set; }

    public string? Name { get; set; }

    public string? CustName { get; set; }

    public int? Itemcode { get; set; }

    public string? ItemName { get; set; }

    public string? Unit { get; set; }

    public float? Order { get; set; }

    public float? Cancel { get; set; }

    public float? Rate { get; set; }

    public float? SnacksRate { get; set; }

    public float? ActualRate { get; set; }

    public DateTime? Tdate { get; set; }
}
