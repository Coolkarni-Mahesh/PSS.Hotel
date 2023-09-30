using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class PurchaseBill
{
    public int? Pbillcode { get; set; }

    public string? BillNo { get; set; }

    public DateTime? Pdate { get; set; }

    public string? CounterPayment { get; set; }

    public int? Suppliercode { get; set; }

    public string? DiscountType { get; set; }

    public string? StockType { get; set; }

    public float? Tcs { get; set; }

    public float? Transport { get; set; }

    public float? SalesTax { get; set; }

    public float? Other { get; set; }

    public float? Discount { get; set; }

    public float? NetAmt { get; set; }

    public string? Remark { get; set; }

    public DateTime? Tpdate { get; set; }

    public float? Tpno { get; set; }

    public string? BillType { get; set; }

    public int? SchAmt { get; set; }

    public int? TradeDis { get; set; }

    public int? Carting { get; set; }

    public int? OpeningFlag { get; set; }
}
