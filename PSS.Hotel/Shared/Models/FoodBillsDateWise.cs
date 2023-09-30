using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class FoodBillsDateWise
{
    public int? Pbillcode { get; set; }

    public DateTime? Tdate { get; set; }

    public string? BillType { get; set; }

    public int? Srno { get; set; }

    public string? ItemName { get; set; }

    public float? Order { get; set; }

    public float? Rate { get; set; }

    public float? Discount { get; set; }

    public int? TableNo { get; set; }

    public int? Persons { get; set; }

    public string? Username { get; set; }

    public string? LastName { get; set; }

    public string? Firstname { get; set; }

    public string? MiddleName { get; set; }

    public float? Fvat { get; set; }

    public float? FvatAmount { get; set; }

    public float? FserviceCharge { get; set; }

    public float? FserviceChargeAmt { get; set; }

    public float? FserviceTax { get; set; }

    public float? FserviceTaxAmt { get; set; }

    public string? TableName { get; set; }

    public float? RoundOff { get; set; }
}
