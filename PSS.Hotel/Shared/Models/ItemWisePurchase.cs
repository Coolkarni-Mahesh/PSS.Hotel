using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ItemWisePurchase
{
    public int? Pbillcode { get; set; }

    public DateTime? Pdate { get; set; }

    public string? RawItem { get; set; }

    public string? GroupName { get; set; }

    public string? Unit { get; set; }

    public float? Qty { get; set; }

    public float? Rate { get; set; }

    public string? DiscountType { get; set; }

    public string? StockType { get; set; }

    public float? Tcs { get; set; }

    public float? Transport { get; set; }

    public float? SalesTax { get; set; }

    public float? Other { get; set; }

    public float? Discount { get; set; }

    public int? OpeningFlag { get; set; }
}
