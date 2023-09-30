using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class BillSummary1
{
    public int? Pbillcode { get; set; }

    public string? BillType { get; set; }

    public float? Billamt { get; set; }

    public DateTime? Tdate { get; set; }
}
