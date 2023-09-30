using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class DayCloseProcessReport
{
    public float? SrNo { get; set; }

    public string? Particular { get; set; }

    public string? Print { get; set; }

    public string? ReportType { get; set; }

    public string? Action { get; set; }

    public string? Status { get; set; }

    public string? SoftwareSettings { get; set; }

    public string? DeleteFlag { get; set; }
}
