using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class StateMaster
{
    public int? Statecode { get; set; }

    public string? StateName { get; set; }

    public int? CountryCode { get; set; }

    public string? Deleteflag { get; set; }
}
