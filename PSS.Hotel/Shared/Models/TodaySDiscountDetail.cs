using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TodaySDiscountDetail
{
    public int? Pbillcode { get; set; }

    public int? Customercode { get; set; }

    public string? Name { get; set; }

    public string? CustName { get; set; }

    public float? Discount { get; set; }

    public float? Billamt { get; set; }

    public string? BillType { get; set; }
}
