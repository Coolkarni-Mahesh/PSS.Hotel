using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class Citymaster
{
    public int? Citycode { get; set; }

    public string? Cityname { get; set; }

    public int? DistrictCode { get; set; }

    public string? Deleteflag { get; set; }
}
