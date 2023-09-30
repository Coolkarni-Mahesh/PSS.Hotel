using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CashMemoReport
{
    public int? Pbillcode { get; set; }

    public DateTime? Tdate { get; set; }

    public string? Name { get; set; }

    public string? PermitNo { get; set; }

    public DateTime? Validupto { get; set; }

    public float? Discount { get; set; }

    public string? BillType { get; set; }

    public string? Cityname { get; set; }

    public double? Amount { get; set; }

    public string? GroupName { get; set; }
}
