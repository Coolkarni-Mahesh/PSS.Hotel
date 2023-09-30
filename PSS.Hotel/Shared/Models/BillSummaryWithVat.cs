using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class BillSummaryWithVat
{
    public int? Holdno { get; set; }

    public int? FoodBillNo { get; set; }

    public float? FoodBillAmt { get; set; }

    public float? FtaxationAmt { get; set; }

    public int? LiquerBillNo { get; set; }

    public float? LiquerBillAmt { get; set; }

    public float? LtaxationAmt { get; set; }

    public DateTime? Tdate { get; set; }

    public int? OtherDiscount { get; set; }

    public int? Credit { get; set; }

    public int? TransNo { get; set; }

    public string? Name { get; set; }

    public string? Remark { get; set; }

    public int? Persons { get; set; }

    public float? RoundOff { get; set; }

    public float? Fdiscount { get; set; }

    public float? Ldiscount { get; set; }

    public float? FvatAmount { get; set; }

    public float? FserviceChargeAmt { get; set; }

    public float? FserviceTaxAmt { get; set; }

    public float? LvatAmount { get; set; }

    public float? LserviceChargeAmt { get; set; }

    public float? LserviceTaxAmt { get; set; }

    public int? CancelItemAfterBilling { get; set; }
}
