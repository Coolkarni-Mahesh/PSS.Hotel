using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class SubgroupMaster
{
    public int? SubGroupcode { get; set; }

    public string? SubGroup { get; set; }

    public DateTime? StockDate { get; set; }

    public string? Deleteflag { get; set; }
}
