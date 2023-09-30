using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class BalancePaymentReport
{
    public int? SupplierCode { get; set; }

    public float? BalancePayment { get; set; }
}
