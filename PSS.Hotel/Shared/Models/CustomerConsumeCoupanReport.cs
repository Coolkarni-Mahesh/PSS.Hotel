using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CustomerConsumeCoupanReport
{
    public int? TransNo { get; set; }

    public int? Pbillcode { get; set; }

    public DateTime? Tdate { get; set; }

    public string? BillType { get; set; }

    public string? CustomerName { get; set; }

    public string? SessionName { get; set; }

    public string? CoupanNo { get; set; }

    public float? UsedCoupan { get; set; }

    public int? SessionCode { get; set; }
}
