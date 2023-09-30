using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class LodgingBillDetail
{
    public string? Name { get; set; }

    public string? BillId { get; set; }

    public float? Amount { get; set; }

    public float? ServiceCharge { get; set; }
}
