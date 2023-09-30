using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class DistrictMaster
{
    public int? DistrictCode { get; set; }

    public string? District { get; set; }

    public int? Statecode { get; set; }

    public string? Deleteflag { get; set; }
}
