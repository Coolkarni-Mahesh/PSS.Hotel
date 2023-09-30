using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class OpeningStockDetail
{
    public int? TransId { get; set; }

    public int? SrNo { get; set; }

    public int? GroupCode { get; set; }

    public int? SubGroupCode { get; set; }

    public int? RawItemId { get; set; }

    public int? UnitCode { get; set; }

    public int? Qty { get; set; }
}
