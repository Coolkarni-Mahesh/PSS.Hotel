using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class SoftwareRegistration
{
    public string? LockType { get; set; }

    public string? LockAllow { get; set; }

    public DateTime? LockDate { get; set; }

    public string? ErrorMessage { get; set; }
}
