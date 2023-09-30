using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class KotBotCancelItem
{
    public int? Pbillcode { get; set; }

    public int? Itemcode { get; set; }

    public int? Unitcode { get; set; }

    public int? Cancel { get; set; }
}
