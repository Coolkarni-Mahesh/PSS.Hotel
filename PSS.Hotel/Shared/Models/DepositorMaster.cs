using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class DepositorMaster
{
    public int? DepositorId { get; set; }

    public string? DepositorName { get; set; }

    public string? Note { get; set; }

    public string? Deleteflag { get; set; }
}
