using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class PrintingSetting
{
    public string? SalesBillPrinting { get; set; }

    public int? FontSize { get; set; }

    public int? NoOfChar { get; set; }
}
