using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class PurchaseLedgerReport
{
    public string? SupplierName { get; set; }

    public DateTime? Tdate { get; set; }

    public string? Ttype { get; set; }

    public string? Tid { get; set; }

    public string? PbillCode { get; set; }

    public float? BillAmt { get; set; }

    public float? PaidAmt { get; set; }
}
