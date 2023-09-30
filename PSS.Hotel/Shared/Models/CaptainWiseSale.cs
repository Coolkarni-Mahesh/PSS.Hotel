using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CaptainWiseSale
{
    public int? CaptainCode { get; set; }

    public string? Name { get; set; }

    public string? BillType { get; set; }

    public double? Bamt { get; set; }

    public DateTime? Tdate { get; set; }

    public string? AliasName { get; set; }

    public int? CommissionBoundary { get; set; }
}
