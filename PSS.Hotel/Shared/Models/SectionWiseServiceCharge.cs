using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class SectionWiseServiceCharge
{
    public int? TransactionId { get; set; }

    public int? SectionId { get; set; }

    public float? FvatCst { get; set; }

    public float? FserviceCharge { get; set; }

    public float? FserviceTax { get; set; }

    public float? LvatCst { get; set; }

    public float? LserviceCharge { get; set; }

    public float? LserviceTax { get; set; }

    public float? ZeroRateAllow { get; set; }
}
