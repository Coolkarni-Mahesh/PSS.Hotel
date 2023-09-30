using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class SalesBillPrintReport
{
    public int? Pbillcode { get; set; }

    public DateTime? Tdate { get; set; }

    public int? Persons { get; set; }

    public string? Capt { get; set; }

    public string? Cust { get; set; }

    public string? User { get; set; }

    public float? Discount { get; set; }

    public float? Billamt { get; set; }

    public string? Type { get; set; }

    public int? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Unit { get; set; }

    public float? Order { get; set; }

    public float? Rate { get; set; }

    public float? Distotal { get; set; }

    public string? TableNo { get; set; }

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

    public int? Holdno { get; set; }

    public int? TransNo { get; set; }

    public string? SectionName { get; set; }

    public string? Remark { get; set; }

    public float? NetAmt { get; set; }

    public float? ActualRate { get; set; }

    public string? Address { get; set; }

    public string? PhoneNo { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public string? SessionName { get; set; }

    public string? CoupanNo { get; set; }

    public int? CoupanQty { get; set; }

    public int? CoupanBal { get; set; }

    public DateTime? MessStartDate { get; set; }

    public string? CardNo { get; set; }

    public string? Gstno { get; set; }

    public string? SalesBillPrint { get; set; }

    public string? Gst { get; set; }

    public string? Name { get; set; }

    public string? Add1 { get; set; }

    public string? Add2 { get; set; }

    public string? SubName { get; set; }

    public string? LicenceNo { get; set; }

    public string? City { get; set; }

    public string? OrgPhone { get; set; }

    public string? Vat { get; set; }

    public string? FoodLicNo { get; set; }

    public byte[]? Image { get; set; }
}
