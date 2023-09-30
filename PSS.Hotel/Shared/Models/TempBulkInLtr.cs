using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TempBulkInLtr
{
    public int? Id { get; set; }

    public float? Opening { get; set; }

    public float? Received { get; set; }

    public float? Sale { get; set; }

    public float? Closing { get; set; }

    public string? GroupName { get; set; }
}
