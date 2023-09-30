using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class OnlineExUnitWiseSalesAndPurchase
{
    public int? ExciseGroupId { get; set; }

    public string? ExciseGroupName { get; set; }

    public string? Unit { get; set; }

    public string? Ml { get; set; }

    public int? TodaySpqty { get; set; }

    public string? BackSpqty { get; set; }
}
