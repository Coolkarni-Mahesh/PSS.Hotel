using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ExpensesRegister
{
    public int? TranNo { get; set; }

    public DateTime? Edate { get; set; }

    public string? Particular { get; set; }

    public float? Amount { get; set; }

    public string? Description { get; set; }
}
