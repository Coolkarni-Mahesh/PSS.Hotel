using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TempExpensesAndPurPaymentDetail
{
    public DateTime? TrDate { get; set; }

    public int? SrNo { get; set; }

    public string? Particular { get; set; }

    public string? Unit { get; set; }

    public string? TransactionType { get; set; }

    public float? Qty { get; set; }

    public float? FreeQty { get; set; }

    public float? Rate { get; set; }

    public double? Amount { get; set; }

    public string? ExpItemDescription { get; set; }

    public string? ExpGroupName { get; set; }

    public float? PurReturnAmt { get; set; }

    public string? PaymentType { get; set; }

    public string? PaymentRemark { get; set; }

    public string? PaymentChqNo { get; set; }

    public string? PaymentBankName { get; set; }

    public DateTime? PaymentChqDate { get; set; }

    public int? PaymentPbillNo { get; set; }

    public int? Ppno { get; set; }
}
