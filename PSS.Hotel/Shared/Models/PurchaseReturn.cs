using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class PurchaseReturn
{
    public int? Prcode { get; set; }

    public DateTime? Pdate { get; set; }

    public int? Suppliercode { get; set; }

    public string? DiscountType { get; set; }

    public string? StockType { get; set; }

    public float? Discount { get; set; }

    public float? NetAmt { get; set; }

    public string? Remark { get; set; }

    public string? Paid { get; set; }

    public int? Paidamt { get; set; }
}
