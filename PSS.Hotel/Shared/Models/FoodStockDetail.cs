using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class FoodStockDetail
{
    public int? RawItemCode { get; set; }

    public string? RawName { get; set; }

    public int? Srno { get; set; }

    public float? OpeningBalance { get; set; }

    public float? Receipt { get; set; }

    public float? Preturn { get; set; }

    public float? Total { get; set; }

    public float? ComputerC { get; set; }

    public float? StockC { get; set; }

    public float? Wastage { get; set; }

    public float? Different { get; set; }

    public float? ClosingStock { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? Remark { get; set; }
}
