using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class StockDetail
{
    public int? RawitemId { get; set; }

    public string? RawItemName { get; set; }

    public float? Receipt { get; set; }

    public float? Sale { get; set; }

    public float? Cancel { get; set; }

    public float? Closing { get; set; }
}
