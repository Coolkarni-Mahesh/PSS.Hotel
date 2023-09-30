using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class SmsmessageMaster
{
    public int SmsmessageCode { get; set; }

    public string? SmsmessageName { get; set; }

    public int? NoOfVariable { get; set; }

    public string? SendTo { get; set; }

    public string? Smstype { get; set; }

    public string? Deleteflag { get; set; }
}
