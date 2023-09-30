using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class OpeningStockMaster
{
    public int? TransId { get; set; }

    public DateTime? Tdate { get; set; }

    public string? OpeningMonth { get; set; }

    public int? Empno { get; set; }

    public string? Remark { get; set; }

    public string? Deleteflag { get; set; }
}
