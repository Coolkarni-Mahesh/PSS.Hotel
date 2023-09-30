using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class OpeningStockFormatReport
{
    public int? ExciseGroupId { get; set; }

    public int? Itemcode { get; set; }

    public string? ItemName { get; set; }

    public int? Unitcode { get; set; }

    public float? Ml { get; set; }

    public string? Unit { get; set; }

    public string? GroupName { get; set; }

    public string? ExciseGroupName { get; set; }

    public string? PackingType { get; set; }

    public float? LiquerRate { get; set; }

    public int? SectionId { get; set; }

    public string? Deleteflag { get; set; }
}
