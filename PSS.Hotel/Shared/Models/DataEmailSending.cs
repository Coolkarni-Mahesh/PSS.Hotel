using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class DataEmailSending
{
    public string? FromEmailId { get; set; }

    public string? FromPassword { get; set; }

    public string? ToEmailId { get; set; }

    public string? StateFlag { get; set; }

    public string? Smptserver { get; set; }
}
