using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class FunctionProspectusDetail
{
    public int? TransactionId { get; set; }

    public int? SrNo { get; set; }

    public int? MenuTypeId { get; set; }

    public DateTime? Tdate { get; set; }

    public string? TdateTime { get; set; }

    public float? Pax { get; set; }

    public float? Amount { get; set; }
}
