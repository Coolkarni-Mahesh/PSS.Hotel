using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TempLiquorItemStockLedgerReport
{
    public DateTime? Date { get; set; }

    public int? RawitemId { get; set; }

    public string? ItemName { get; set; }

    public int? SrNo { get; set; }

    public string? Type { get; set; }

    public int? UnitCode { get; set; }

    public string? Unit { get; set; }

    public int? BillId { get; set; }

    public int? InQty { get; set; }

    public int? OutQty { get; set; }

    public int? BalQty { get; set; }

    public int? Excise { get; set; }

    public string? DataPrint { get; set; }
}
