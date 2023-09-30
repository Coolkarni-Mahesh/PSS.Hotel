using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CancelItemReport
{
    public DateTime? Tdate { get; set; }

    public string? SubGroup { get; set; }

    public string? ItemName { get; set; }

    public string? Unit { get; set; }

    public double? Cancel { get; set; }

    public string? TableName { get; set; }

    public string? Reason { get; set; }

    public string? Ttime { get; set; }

    public string? Name { get; set; }

    public string? StartTime { get; set; }
}
