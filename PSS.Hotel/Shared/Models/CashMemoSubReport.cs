using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CashMemoSubReport
{
    public int? Pbillcode { get; set; }

    public DateTime? Tdate { get; set; }

    public string? BillType { get; set; }

    public string? Name { get; set; }

    public string? PermitNo { get; set; }

    public DateTime? Validupto { get; set; }

    public int? Srno { get; set; }

    public string? ItemName { get; set; }

    public string? Unit { get; set; }

    public float? Order { get; set; }

    public float? Rate { get; set; }

    public float? SnacksRate { get; set; }

    public float? Discount { get; set; }

    public int? Itemcode { get; set; }

    public float? Lvat { get; set; }

    public float? LvatAmount { get; set; }

    public float? LserviceCharge { get; set; }

    public float? LserviceChargeAmt { get; set; }

    public float? LserviceTax { get; set; }

    public float? LserviceTaxAmt { get; set; }

    public float? RoundOff { get; set; }
}
