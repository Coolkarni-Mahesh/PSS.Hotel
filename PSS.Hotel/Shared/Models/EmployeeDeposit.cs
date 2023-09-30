using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class EmployeeDeposit
{
    public int? DepositId { get; set; }

    public DateTime? Ddate { get; set; }

    public int? Empno { get; set; }

    public float? DepositAmt { get; set; }

    public string? Remark { get; set; }

    public int? DepositTo { get; set; }
}
