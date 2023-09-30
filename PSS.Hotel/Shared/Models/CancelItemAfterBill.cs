using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CancelItemAfterBill
{
    public DateTime? Tdate { get; set; }

    public string? BillType { get; set; }

    public string? ItemName { get; set; }

    public string? Unit { get; set; }

    public int? Srno { get; set; }

    public int? CancelItem { get; set; }

    public float? Rate { get; set; }

    public string? Reason { get; set; }

    public int? BillNo { get; set; }

    public string? Ttime { get; set; }
}
