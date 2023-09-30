using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class SessionMaster
{
    public int? SessionCode { get; set; }

    public string? SessionName { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public string? Deleteflag { get; set; }
}
