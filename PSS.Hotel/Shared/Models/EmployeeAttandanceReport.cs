using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class EmployeeAttandanceReport
{
    public DateTime? Tdate { get; set; }

    public int? Srno { get; set; }

    public string? Name { get; set; }

    public float? Attandance { get; set; }

    public string? Remark { get; set; }
}
