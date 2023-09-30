using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class Itemreatedetail
{
    public int? Itemcode { get; set; }

    public string? ItemId { get; set; }

    public string? ItemName { get; set; }

    public int? SectionId { get; set; }

    public float? LiquerRate { get; set; }

    public string? GroupName { get; set; }

    public int? SubGroupcode { get; set; }

    public float? Snacks { get; set; }

    public string? SectionName { get; set; }

    public string? Deleteflag { get; set; }

    public string? Unit { get; set; }

    public string? ExciseItemCode { get; set; }
}
