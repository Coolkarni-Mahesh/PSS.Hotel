using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ReportAlignmentMaster
{
    public int? ReportId { get; set; }

    public string? ReportTitle { get; set; }

    public string? ReportFileName { get; set; }

    public float? PaperSizeId { get; set; }

    public string? PrinterName { get; set; }

    public float? TopMargin { get; set; }

    public float? LeftMargin { get; set; }

    public float? BottomMargin { get; set; }

    public float? RightMargin { get; set; }

    public string? PresentFlag { get; set; }
}
