using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class EmployeeSalary
{
    public int? Empno { get; set; }

    public float? Salary { get; set; }

    public float? Basic { get; set; }

    public string? GrossSalary { get; set; }

    public float? Hra { get; set; }

    public float? WashingAllow { get; set; }

    public float? Ta { get; set; }

    public float? Epf { get; set; }

    public float? Esic { get; set; }
}
