using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CustomerCoupanDepositDetail
{
    public int? TransactionId { get; set; }

    public DateTime? Tdate { get; set; }

    public int? MainSrno { get; set; }

    public int? CoupanId { get; set; }

    public int? Customercode { get; set; }

    public string? CoupanNo { get; set; }

    public int? CoupanQty { get; set; }

    public int? AdvanceQty { get; set; }

    public int? AdjustQty { get; set; }

    public int? ValidDays { get; set; }

    public string? Remark { get; set; }

    public int? CoupanUsed { get; set; }

    public int? CoupanAllow { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }
}
