using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class PurchasePayment
{
    public int? Ppno { get; set; }

    public int? Suppliercode { get; set; }

    public DateTime? Docdate { get; set; }

    public float? Paidamount { get; set; }

    public float? PreturnAmt { get; set; }

    public string? PaymentType { get; set; }

    public string? Remark { get; set; }

    public string? Chequeno { get; set; }

    public int? BankCode { get; set; }

    public DateTime? Chequedate { get; set; }

    public int? PbillNo { get; set; }
}
