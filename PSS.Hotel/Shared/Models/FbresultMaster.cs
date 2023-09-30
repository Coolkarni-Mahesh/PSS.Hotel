using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class FbresultMaster
{
    public DateTime? Tdate { get; set; }

    public int? TableId { get; set; }

    public int? Qid { get; set; }

    public int? Customercode { get; set; }

    public string? Result { get; set; }

    public int? TrId { get; set; }
}
