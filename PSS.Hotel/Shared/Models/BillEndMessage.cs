using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class BillEndMessage
{
    public int? TableId { get; set; }

    public string? Remark { get; set; }

    public string? TableEndFlag { get; set; }
}
