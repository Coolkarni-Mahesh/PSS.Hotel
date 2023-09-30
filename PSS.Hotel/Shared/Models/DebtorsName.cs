using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class DebtorsName
{
    public int? CreditorId { get; set; }

    public string? Name { get; set; }

    public float? Amount { get; set; }
}
