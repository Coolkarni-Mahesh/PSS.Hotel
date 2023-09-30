using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ItemDetail
{
    public int? Itemcode { get; set; }

    public int? SectionId { get; set; }

    public int? Unitcode { get; set; }

    public float? PurchaseRate { get; set; }

    public float? LiquerRate { get; set; }

    public float? Snacks { get; set; }

    public string? ExciseItemCode { get; set; }

    public string? Barcode { get; set; }
}
