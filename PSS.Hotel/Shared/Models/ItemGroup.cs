using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ItemGroup
{
    public int? ItemGroupCode { get; set; }

    public string? GroupName { get; set; }

    public int? SubGroupcode { get; set; }

    public string? Deleteflag { get; set; }

    public string? Ordertype { get; set; }

    public float? Gsttax { get; set; }

    public string? Sacno { get; set; }

    public short? GroupSequence { get; set; }
}
