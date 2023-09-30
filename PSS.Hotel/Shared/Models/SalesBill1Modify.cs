using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class SalesBill1Modify
{
    public int? UpdationSequence { get; set; }

    public int? TransNo { get; set; }

    public int? Pbillcode { get; set; }

    public DateTime? Tdate { get; set; }

    public int? TableNo { get; set; }

    public string BillType { get; set; } = null!;

    public int? Holdno { get; set; }

    public int? Customercode { get; set; }

    public string? CustName { get; set; }

    public int? CaptainCode { get; set; }

    public int? WetterCode { get; set; }

    public int? Persons { get; set; }

    public float? Discount { get; set; }

    public float? Billamt { get; set; }

    public int? PaidAmt { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public int? Usercode { get; set; }

    public float? Fvat { get; set; }

    public float? FvatAmount { get; set; }

    public float? Lvat { get; set; }

    public float? LvatAmount { get; set; }

    public float? FserviceCharge { get; set; }

    public float? FserviceChargeAmt { get; set; }

    public float? LserviceCharge { get; set; }

    public float? LserviceChargeAmt { get; set; }

    public float? FserviceTax { get; set; }

    public float? FserviceTaxAmt { get; set; }

    public float? LserviceTax { get; set; }

    public float? LserviceTaxAmt { get; set; }

    public float? RoundOff { get; set; }

    public DateTime? PrintingDate { get; set; }

    public float? DiscountPer { get; set; }
}
