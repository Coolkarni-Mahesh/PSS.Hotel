using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TableMaster
{
    public int? TableNo { get; set; }

    public int? TableId { get; set; }

    public string? Description { get; set; }

    public string? DeleteFlag { get; set; }

    public int? SrNo { get; set; }
}
