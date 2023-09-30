using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TempCreditorDetailYc
{
    public int? SrNo { get; set; }

    public int? CreditorId { get; set; }

    public string? CreditorName { get; set; }

    public double? Amount { get; set; }
}
