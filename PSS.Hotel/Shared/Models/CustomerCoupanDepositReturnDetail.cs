using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CustomerCoupanDepositReturnDetail
{
    public int? TransactionId { get; set; }

    public DateTime? Tdate { get; set; }

    public int? SrNo { get; set; }

    public int? Customercode { get; set; }

    public int? CoupanQty { get; set; }

    public int? CoupanUsed { get; set; }

    public int? ReturnQty { get; set; }

    public int? ReturnAmount { get; set; }

    public string? Remark { get; set; }
}
