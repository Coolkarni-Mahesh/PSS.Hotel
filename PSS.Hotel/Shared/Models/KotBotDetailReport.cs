using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class KotBotDetailReport
{
    public int? Pbillcode { get; set; }

    public DateTime? Tdate { get; set; }

    public string? Kotdata { get; set; }

    public string? Botdata { get; set; }

    public string? ItemName { get; set; }

    public string? Unit { get; set; }

    public int? Cancel { get; set; }
}
