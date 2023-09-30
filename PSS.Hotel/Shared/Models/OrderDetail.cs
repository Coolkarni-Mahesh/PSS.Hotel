using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class OrderDetail
{
    public int? Srno { get; set; }

    public string? CustomerName { get; set; }

    public int? Pax { get; set; }

    public int? Empno { get; set; }

    public int? TableId { get; set; }

    public int? Itemcode { get; set; }

    public int? Order { get; set; }

    public int? Unitcode { get; set; }

    public string? TasteName { get; set; }

    public float? Rate { get; set; }
}
