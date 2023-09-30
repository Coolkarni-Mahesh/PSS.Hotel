using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class SupplierPaymentDetail
{
    public int? Ppno { get; set; }

    public string? Name { get; set; }

    public DateTime? Docdate { get; set; }

    public float? Paidamount { get; set; }

    public string? PaymentType { get; set; }

    public string? Chequeno { get; set; }
}
