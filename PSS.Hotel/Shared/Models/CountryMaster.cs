using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CountryMaster
{
    public int? CountryCode { get; set; }

    public string? CountryName { get; set; }

    public string? Deleteflag { get; set; }
}
