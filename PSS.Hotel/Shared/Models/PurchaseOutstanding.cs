using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class PurchaseOutstanding
{
    public string? Name { get; set; }

    public string? Cityname { get; set; }

    public float? BalancePayment { get; set; }

    public int? SupplierCode { get; set; }
}
