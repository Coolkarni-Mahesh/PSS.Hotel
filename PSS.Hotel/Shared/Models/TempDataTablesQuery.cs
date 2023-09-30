using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TempDataTablesQuery
{
    public int? SrNo { get; set; }

    public string? QueryName { get; set; }

    public string? DeleteFlag { get; set; }
}
