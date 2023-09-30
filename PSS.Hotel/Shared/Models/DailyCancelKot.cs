﻿using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class DailyCancelKot
{
    public int? CancelKotNo { get; set; }

    public DateTime? Tdate { get; set; }

    public int? Tableno { get; set; }

    public int? Itemcode { get; set; }

    public int? Unitcode { get; set; }

    public int? Qty { get; set; }

    public string? Printflag { get; set; }

    public string? Reason { get; set; }

    public int? Departmentcode { get; set; }

    public string? Ttime { get; set; }
}
