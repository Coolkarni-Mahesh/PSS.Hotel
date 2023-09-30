using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class AdiscountDetail
{
    public int? TransNo { get; set; }

    public int? Pbillcode { get; set; }

    public DateTime? Tdate { get; set; }

    public string BillType { get; set; } = null!;

    public int? Customercode { get; set; }

    public string? CustName { get; set; }

    public float? Billamt { get; set; }

    public int? Discount { get; set; }
}
