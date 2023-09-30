using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class Casess1Report
{
    public int? TransactionId { get; set; }

    public DateTime? Tdate { get; set; }

    public float? Food { get; set; }

    public int? Beer { get; set; }

    public float? Bar { get; set; }

    public int? Softdrink { get; set; }

    public float? Cigarette { get; set; }

    public float? Lodging { get; set; }

    public int? CounterSnacks { get; set; }

    public float? Vat { get; set; }

    public int? Opening { get; set; }

    public double? Total1 { get; set; }

    public float? Discount { get; set; }

    public double? Total2 { get; set; }

    public float? Credit { get; set; }

    public double? Total3 { get; set; }

    public float? Expenses { get; set; }

    public int? Advance { get; set; }

    public float? PurchasePayment { get; set; }

    public double? Total4 { get; set; }

    public float? DepositCheque { get; set; }

    public float? DepositCash { get; set; }

    public float? OtherDeposit { get; set; }

    public double? NetAmount { get; set; }

    public int? DepositAmt { get; set; }

    public double? ClosingAmt { get; set; }

    public string? DepositName { get; set; }
}
