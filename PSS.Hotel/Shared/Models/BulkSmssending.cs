using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class BulkSmssending
{
    public int? Tid { get; set; }

    public DateTime? Tdate { get; set; }

    public int? SmsmessageCode { get; set; }

    public string? MobileNo { get; set; }

    public string? Message { get; set; }

    public string? Remark { get; set; }

    public int? Usercode { get; set; }
}
