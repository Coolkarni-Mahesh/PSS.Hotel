using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class PurchaseDetail
{
    public int? Pbillcode { get; set; }

    public int? Suppliercode { get; set; }

    public string? Name { get; set; }

    public DateTime? Pdate { get; set; }

    public string? BillNo { get; set; }

    public float? NetAmt { get; set; }

    public int? OpeningFlag { get; set; }
}
