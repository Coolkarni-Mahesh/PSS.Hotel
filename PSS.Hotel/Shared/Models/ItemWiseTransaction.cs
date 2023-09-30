using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ItemWiseTransaction
{
    public DateTime? Date { get; set; }

    public string? IitemName { get; set; }

    public string? Type { get; set; }

    public string? Unit { get; set; }

    public int? BillId { get; set; }

    public int? Qty { get; set; }

    public int? Ml { get; set; }
}
