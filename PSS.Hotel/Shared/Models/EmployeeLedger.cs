using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class EmployeeLedger
{
    public string? TransType { get; set; }

    public double? Amount { get; set; }

    public DateTime? Tdate { get; set; }
}
