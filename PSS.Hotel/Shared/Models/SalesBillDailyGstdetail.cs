using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class SalesBillDailyGstdetail
{
    public int? TransNo { get; set; }

    public int? Pbillcode { get; set; }

    public DateTime? Tdate { get; set; }

    public string? BillType { get; set; }

    public float? Gstrate { get; set; }

    public float? TaxableAmt { get; set; }

    public float? Gstamt { get; set; }
}
