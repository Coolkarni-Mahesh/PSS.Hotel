using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class SoftwareSetting
{
    public int? SrNo { get; set; }

    public string? Title { get; set; }

    public string? Condition { get; set; }

    public string? Description { get; set; }

    public string? ConditionData { get; set; }

    public string? UsedBy { get; set; }
}
