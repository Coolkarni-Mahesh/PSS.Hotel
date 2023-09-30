using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class Fymaster
{
    public int? Fycode { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }

    public string? CloseFlag { get; set; }
}
