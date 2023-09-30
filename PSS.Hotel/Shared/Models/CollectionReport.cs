using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CollectionReport
{
    public string? CustomerName { get; set; }

    public DateTime? Pdate { get; set; }

    public float? PaidAmount { get; set; }

    public string? PaidType { get; set; }

    public string? ChequeNo { get; set; }

    public DateTime? Chequedate { get; set; }
}
