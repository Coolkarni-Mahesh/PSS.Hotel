using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class SmssendingDetail
{
    public DateTime? Tdate { get; set; }

    public string? SendFlag { get; set; }

    public string? Ftype { get; set; }

    public string? MobileNo { get; set; }

    public string? SmstextMsg { get; set; }

    public int? TransactionId { get; set; }

    public string? SendTo { get; set; }
}
