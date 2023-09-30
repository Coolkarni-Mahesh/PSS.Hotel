using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CustomerWiseCoupanDetailDateWise
{
    public DateTime? Tdate { get; set; }

    public int? Customercode { get; set; }

    public string? Name { get; set; }

    public string? ItemName { get; set; }

    public int? CoupanId { get; set; }

    public string? CoupanNo { get; set; }

    public int? CoupanQty { get; set; }

    public int? AdvanceQty { get; set; }

    public int? AdjustQty { get; set; }

    public int? ValidDays { get; set; }

    public string? Remark { get; set; }

    public int? CoupanUsed { get; set; }

    public int? CoupanAllow { get; set; }

    public string? CashType { get; set; }

    public float? Amount { get; set; }

    public string? CardNo { get; set; }

    public DateTime? StartDate { get; set; }

    public double? SumOfOrder { get; set; }

    public DateTime? DepDate { get; set; }
}
