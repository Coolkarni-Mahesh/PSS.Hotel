using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class SpecialDishGroupMaster
{
    public int? SdgroupId { get; set; }

    public string? SdgroupName { get; set; }

    public string? DeleteFlag { get; set; }
}
