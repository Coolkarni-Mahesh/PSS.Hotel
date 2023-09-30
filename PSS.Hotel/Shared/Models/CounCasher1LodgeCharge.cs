using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CounCasher1LodgeCharge
{
    public int? TransactionId { get; set; }

    public float? BobCard { get; set; }

    public float? HouseKeeping { get; set; }

    public float? HouseGuest { get; set; }
}
