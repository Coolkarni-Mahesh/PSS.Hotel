using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TempCurrentStockAverageRate
{
    public int? RawitemId { get; set; }

    public float? OpeningQty { get; set; }

    public float? OpeningRate { get; set; }

    public float? ReceiveQty { get; set; }

    public float? ReceiveRate { get; set; }

    public float? TotalQty { get; set; }

    public float? TotalRate { get; set; }

    public float? IssueQty { get; set; }

    public float? IssueRate { get; set; }

    public float? ClosingQty { get; set; }

    public float? ClosingRate { get; set; }

    public float? AvgRate { get; set; }
}
