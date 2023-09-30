using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class MonthlyFoodBillSummary
{
    public int? Srno { get; set; }

    public DateTime? Month { get; set; }

    public float? SoftDrinkAmt { get; set; }

    public float? FoodBillAmt { get; set; }

    public string? BillNo { get; set; }

    public float? VatAmt { get; set; }

    public float? ServiceChargeAmt { get; set; }

    public float? ServiceTaxAmt { get; set; }

    public float? TaxationAmount { get; set; }

    public double? RoundOff { get; set; }

    public int? BeerAndWineAmt { get; set; }
}
