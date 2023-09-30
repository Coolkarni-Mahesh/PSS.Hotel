using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CreditReferenceCashMemoReport
{
    public int? Pbillcode { get; set; }

    public DateTime? Tdate { get; set; }

    public string? BillType { get; set; }

    public string? Name { get; set; }

    public double? BillAmount { get; set; }

    public int? DirectSbillNo { get; set; }
}
