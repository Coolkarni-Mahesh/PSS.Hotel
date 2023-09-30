using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class BillSummary
{
    public int? Holdno { get; set; }

    public int? FoodBillNo { get; set; }

    public float? FoodBillAmt { get; set; }

    public int? LiquerBillNo { get; set; }

    public float? LiquerBillAmt { get; set; }

    public DateTime? Tdate { get; set; }

    public int? Discount { get; set; }

    public int? Credit { get; set; }

    public int? TransNo { get; set; }

    public string? Name { get; set; }

    public string? Remark { get; set; }

    public int? Persons { get; set; }

    public string? TableNo { get; set; }

    public float? VatAmount { get; set; }

    public float? ServiceChargeAmt { get; set; }

    public float? ServiceTaxAmt { get; set; }

    public double? RoundOff { get; set; }

    public string? FoodDiscount { get; set; }

    public string? LiquareDiscount { get; set; }
}
