using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class RoundOffQuery
{
    public int? Pbillcode { get; set; }

    public float? Billamt { get; set; }

    public float? RoundOff { get; set; }

    public DateTime? Tdate { get; set; }

    public string? BillType { get; set; }
}
