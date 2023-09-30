using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class SalaryAdvanceSummary
{
    public int? Empno { get; set; }

    public string? LastName { get; set; }

    public string? Firstname { get; set; }

    public string? MiddleName { get; set; }

    public double? Balance { get; set; }

    public int? GrossSalary { get; set; }
}
