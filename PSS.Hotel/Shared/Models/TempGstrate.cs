using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TempGstrate
{
    public int? TableId { get; set; }

    public int? Srno { get; set; }

    public float? GstRate { get; set; }

    public float? TaxableAmt { get; set; }

    public float? Gstamt { get; set; }
}
