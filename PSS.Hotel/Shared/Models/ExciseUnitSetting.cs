using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ExciseUnitSetting
{
    public int? Srno { get; set; }

    public int? ExciseGroupId { get; set; }

    public int? Unitcode1 { get; set; }

    public int? UnitCode2 { get; set; }

    public float? UnitLimit { get; set; }
}
