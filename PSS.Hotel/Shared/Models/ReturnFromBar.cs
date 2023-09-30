using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ReturnFromBar
{
    public int? ReturnId { get; set; }

    public DateTime? Idate { get; set; }

    public int? Empno { get; set; }

    public string? Remark { get; set; }

    public int? BarCounterId { get; set; }
}
