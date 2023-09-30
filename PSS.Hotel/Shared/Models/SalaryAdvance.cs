using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class SalaryAdvance
{
    public int? TransactionId { get; set; }

    public int? Empno { get; set; }

    public DateTime? Tdate { get; set; }

    public float? Advance { get; set; }

    public string? IssuedBy { get; set; }

    public string? Remark { get; set; }
}
