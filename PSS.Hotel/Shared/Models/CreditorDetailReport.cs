using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CreditorDetailReport
{
    public int? CreditorId { get; set; }

    public string? CreditorName { get; set; }

    public float? Amount { get; set; }

    public string? MobileNo { get; set; }
}
