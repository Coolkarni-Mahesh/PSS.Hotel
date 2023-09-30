using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TableRotaion
{
    public int? TransNo { get; set; }

    public string? TableName { get; set; }

    public float? Billamt { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public string? ConsumeTime { get; set; }

    public DateTime? StartDate { get; set; }
}
