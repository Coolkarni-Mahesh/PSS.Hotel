using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class FoodBillSummaryCreditBill
{
    public int? Pbillcode { get; set; }

    public DateTime? Tdate { get; set; }

    public string? BillType { get; set; }

    public int? Srno { get; set; }

    public string? ItemName { get; set; }

    public float? Discount { get; set; }

    public int? TableNo { get; set; }

    public int? Persons { get; set; }

    public string? Username { get; set; }

    public string? LastName { get; set; }

    public string? Firstname { get; set; }

    public string? MiddleName { get; set; }

    public int? Customercode { get; set; }

    public string? Name { get; set; }

    public string? CustName { get; set; }

    public string? TableName { get; set; }

    public int? CreditId { get; set; }

    public string? CreditorName { get; set; }

    public double? ServiceCharge { get; set; }

    public double? ServiceChargeTax { get; set; }

    public string? Gst { get; set; }

    public double? Amt { get; set; }

    public float? Rate { get; set; }

    public float? Order { get; set; }
}
