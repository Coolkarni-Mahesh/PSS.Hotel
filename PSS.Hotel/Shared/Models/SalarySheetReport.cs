using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class SalarySheetReport
{
    public int? TransactionNo { get; set; }

    public string? Name { get; set; }

    public DateTime? Tdate { get; set; }

    public float? Holidays { get; set; }

    public float? PresentDays { get; set; }

    public float? ExtraDays { get; set; }

    public float? WithoutPay { get; set; }

    public float? Salary { get; set; }

    public float? PaySalary { get; set; }

    public float? OverTime { get; set; }

    public float? OtherEar { get; set; }

    public float? Advance { get; set; }

    public float? OtherDed { get; set; }
}
