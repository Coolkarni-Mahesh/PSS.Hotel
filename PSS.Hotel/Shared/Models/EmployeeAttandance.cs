using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class EmployeeAttandance
{
    public int? TransactionId { get; set; }

    public DateTime? Tdate { get; set; }

    public int? EmpNo { get; set; }

    public int? Srno { get; set; }

    public float? Attandance { get; set; }

    public string? Remark { get; set; }
}
