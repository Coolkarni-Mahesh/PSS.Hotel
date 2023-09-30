using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class EmpAdvanceReport
{
    public int? TransactionId { get; set; }

    public string? Empname { get; set; }

    public float? Advance { get; set; }

    public DateTime? Tdate { get; set; }

    public string? IssuedBy { get; set; }
}
