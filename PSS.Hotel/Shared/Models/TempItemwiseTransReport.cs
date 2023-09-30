using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TempItemwiseTransReport
{
    public DateTime? Tdate { get; set; }

    public int? PbillCode { get; set; }

    public string? Punit { get; set; }

    public int? Porder { get; set; }

    public int? StransNo { get; set; }

    public int? SbillCode { get; set; }

    public string? Sunit { get; set; }

    public int? Sorder { get; set; }
}
