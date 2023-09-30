using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CancelItemAfterBilling
{
    public DateTime? Tdate { get; set; }

    public int? Icode { get; set; }

    public int? Ucode { get; set; }

    public int? Srno { get; set; }

    public int? BillNo { get; set; }

    public string? BillType { get; set; }

    public int? CancelItem { get; set; }

    public float? Rate { get; set; }

    public string? Reason { get; set; }

    public float? SalesRate { get; set; }

    public float? SnacksRate { get; set; }

    public float? FvatAmount { get; set; }

    public float? LvatAmount { get; set; }

    public float? FserviceChargeAmt { get; set; }

    public float? LserviceChargeAmt { get; set; }

    public float? FserviceTaxAmt { get; set; }

    public float? LserviceTaxAmt { get; set; }

    public string? Ttime { get; set; }
}
