using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ComplimentaryBillWise
{
    public int? SrNo { get; set; }

    public DateTime? Tdate { get; set; }

    public string? ComplimentaryType { get; set; }

    public int? Tid { get; set; }

    public int? PbillNo { get; set; }

    public string? TableName { get; set; }

    public string? CustomerName { get; set; }

    public float? FoodBillAmt { get; set; }

    public float? LiquerBillAmt { get; set; }

    public double? NetAmt { get; set; }

    public string? Remark { get; set; }
}
