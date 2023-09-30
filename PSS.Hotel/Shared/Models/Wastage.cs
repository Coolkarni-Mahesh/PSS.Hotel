using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class Wastage
{
    public int? WastageId { get; set; }

    public DateTime? Idate { get; set; }

    public string? StockType { get; set; }

    public int? Empno { get; set; }

    public string? Remark { get; set; }
}
