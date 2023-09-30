using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class MessageMaster
{
    public int? MessageId { get; set; }

    public string? Message { get; set; }

    public string? Deleteflag { get; set; }
}
