using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CreditorBalanceReport
{
    public int? CreditorId { get; set; }

    public string? CreditorName { get; set; }

    public float? Amount { get; set; }

    public string? MobileNo { get; set; }
}
