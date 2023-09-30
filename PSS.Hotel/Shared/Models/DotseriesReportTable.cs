using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class DotseriesReportTable
{
    public DateTime? Tdate { get; set; }

    public int? Tid { get; set; }

    public string? TableNo { get; set; }

    public string? SalesBillNo { get; set; }

    public string? ItemDepartment { get; set; }

    public string? Dotno { get; set; }
}
