using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ExpensesGroup
{
    public int? EgroupId { get; set; }

    public string? EgroupName { get; set; }

    public string? Deleteflag { get; set; }
}
