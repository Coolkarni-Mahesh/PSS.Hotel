using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CustomerDetail
{
    public string? CustomerName { get; set; }

    public float? Discount { get; set; }

    public DateTime? Tdate { get; set; }

    public string? BillType { get; set; }

    public int? Itemcode { get; set; }

    public int? Unitcode { get; set; }

    public float? Order { get; set; }

    public float? Cancel { get; set; }

    public float? Rate { get; set; }

    public float? SnacksRate { get; set; }
}
