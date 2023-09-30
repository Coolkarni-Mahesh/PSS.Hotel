using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TempGstdetail
{
    public int? Pbillcode { get; set; }

    public DateTime? Tdate { get; set; }

    public string? BillType { get; set; }

    public string? Name { get; set; }

    public int? Billamt { get; set; }

    public int? Gstrate { get; set; }

    public int? TaxableAmt { get; set; }

    public int? Gstamt { get; set; }

    public string? Gst { get; set; }

    public int? Customercode { get; set; }

    public double? RoundOff { get; set; }
}
