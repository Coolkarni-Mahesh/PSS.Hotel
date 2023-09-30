using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class BarCounterMaster
{
    public int? BarCounterId { get; set; }

    public string? BarCounterName { get; set; }

    public string? Deleteflag { get; set; }

    public string? SalesBillPrinterName { get; set; }

    public string? KitchenPrinterName { get; set; }

    public string? BarPrinterName { get; set; }

    public string? CounterPrinterName { get; set; }
}
