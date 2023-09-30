using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ComplimentaryBill
{
    public string? ComplimentaryType { get; set; }

    public int? Tid { get; set; }

    public int? PbillNo { get; set; }

    public string? BillType { get; set; }

    public string? TableName { get; set; }

    public string? CustomerName { get; set; }

    public string? ItemName { get; set; }

    public string? Unit { get; set; }

    public float? Qty { get; set; }

    public float? BillRate { get; set; }

    public float? ActualRate { get; set; }

    public DateTime? Tdate { get; set; }
}
