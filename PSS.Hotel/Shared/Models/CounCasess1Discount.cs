using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CounCasess1Discount
{
    public int? TransactionId { get; set; }

    public int? BillNo { get; set; }

    public int? SrNo { get; set; }

    public float? BillAmt { get; set; }

    public int? Discount { get; set; }

    public string? Billtype { get; set; }

    public int? Customercode { get; set; }

    public string? Custname { get; set; }

    public string? Reason { get; set; }
}
