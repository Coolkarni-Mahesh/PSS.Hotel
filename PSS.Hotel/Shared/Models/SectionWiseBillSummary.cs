using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class SectionWiseBillSummary
{
    public string? SectionName { get; set; }

    public string? TableNo { get; set; }

    public string? Name { get; set; }

    public int? Holdno { get; set; }

    public int? FoodBillNo { get; set; }

    public float? FoodBillAmt { get; set; }

    public int? LiquerBillNo { get; set; }

    public float? LiquerBillAmt { get; set; }

    public DateTime? Tdate { get; set; }

    public float? Discount { get; set; }

    public float? Credit { get; set; }

    public float? CreditCard { get; set; }

    public int? TransNo { get; set; }
}
