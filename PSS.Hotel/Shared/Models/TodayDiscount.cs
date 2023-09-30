using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TodayDiscount
{
    public int? BillNo { get; set; }

    public DateTime? Tdate { get; set; }

    public string? CardNo { get; set; }

    public string? CustName { get; set; }

    public string? BillType { get; set; }

    public float? BillAmt { get; set; }

    public float? Discount { get; set; }

    public float? DiscountPer { get; set; }

    public string? DiscountType { get; set; }

    public string? TableName { get; set; }
}
