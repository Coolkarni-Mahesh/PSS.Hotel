using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class SalaryAdvanceReport
{
    public int? TransactionId { get; set; }

    public int? Empno { get; set; }

    public string? Firstname { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public DateTime? Tdate { get; set; }

    public float? Advance { get; set; }

    public string? IssuedBy { get; set; }

    public string? Deleteflag { get; set; }

    public double? Balance { get; set; }

    public string? Remark { get; set; }
}
