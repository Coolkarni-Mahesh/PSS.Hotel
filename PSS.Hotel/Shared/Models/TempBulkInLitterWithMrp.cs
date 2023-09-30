using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TempBulkInLitterWithMrp
{
    public string? NameAddress { get; set; }

    public string? ExciseLicNo { get; set; }

    public float? ImflbulkInLtr { get; set; }

    public float? BeerBulkInLtr { get; set; }

    public float? WineBulkInLtr { get; set; }

    public float? Imflmrpamt { get; set; }

    public float? BeerMrpamt { get; set; }

    public float? WineMrpamt { get; set; }

    public float? CountryBulkInLtr { get; set; }

    public float? CountryMrpamt { get; set; }
}
