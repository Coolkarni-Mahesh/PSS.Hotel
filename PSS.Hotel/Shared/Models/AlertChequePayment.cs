using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class AlertChequePayment
{
    public string? SupplierName { get; set; }

    public DateTime? ChequeDate { get; set; }

    public float? Amount { get; set; }
}
