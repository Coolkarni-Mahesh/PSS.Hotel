using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ReportPrinterSetMaster
{
    public int? PaperSizeId { get; set; }

    public string? PaperSize { get; set; }

    public string? PrinterName { get; set; }

    public float? TopMargin { get; set; }

    public float? LeftMargin { get; set; }

    public float? BottomMargin { get; set; }

    public float? RightMargin { get; set; }
}
