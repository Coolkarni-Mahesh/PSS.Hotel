using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ExpensesMaster
{
    public int? ExpensesId { get; set; }

    public string? Expenses { get; set; }

    public int? EgroupId { get; set; }

    public string? Deleteflag { get; set; }
}
