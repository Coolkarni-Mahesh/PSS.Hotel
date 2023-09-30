using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class FoodStockDetailReportBefore
{
    public string? RawItem { get; set; }

    public float? OpeningBalance { get; set; }

    public float? Receipt { get; set; }

    public float? ComputerC { get; set; }

    public float? StockC { get; set; }

    public float? Preturn { get; set; }

    public float? Wastage { get; set; }
}
