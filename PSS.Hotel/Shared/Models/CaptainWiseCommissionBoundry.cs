using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CaptainWiseCommissionBoundry
{
    public int? EmpCode { get; set; }

    public string? EmpName { get; set; }

    public int? FoodSale { get; set; }

    public int? LiquorSale { get; set; }

    public DateTime? Tdate { get; set; }

    public int? TotalSale { get; set; }

    public int? CommissionBoundary { get; set; }
}
