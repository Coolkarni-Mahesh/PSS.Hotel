using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CustomerDetailReport
{
    public DateTime? Tdate { get; set; }

    public string? CustName { get; set; }

    public string? ItemName { get; set; }

    public string? Unit { get; set; }

    public double? SumOfOrder { get; set; }

    public double? SumOfDiscount { get; set; }

    public double? Amt { get; set; }
}
