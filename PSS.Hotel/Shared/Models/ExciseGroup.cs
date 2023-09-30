using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ExciseGroup
{
    public int? ExciseGroupId { get; set; }

    public string? ExciseGroupName { get; set; }

    public string? DeleteFlag { get; set; }

    public int? SequenceNo { get; set; }

    public int? UnderId { get; set; }
}
