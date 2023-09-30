using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class UnitMaster
{
    public int? Unitcode { get; set; }

    public string? Unit { get; set; }

    public string? UnitType { get; set; }

    public float? Ml { get; set; }

    public string? Deleteflag { get; set; }

    public string? PackingType { get; set; }

    public int? SequenceNo { get; set; }

    public float? CaseQty { get; set; }

    public string? LiquorType { get; set; }
}
