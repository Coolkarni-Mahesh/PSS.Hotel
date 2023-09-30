using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class UserWiseBillDetail
{
    public int? BillNo { get; set; }

    public float? BillAmt { get; set; }

    public DateTime? Tdate { get; set; }

    public string? UserName { get; set; }
}
