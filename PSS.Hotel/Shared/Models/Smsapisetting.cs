using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class Smsapisetting
{
    public int? Apicode { get; set; }

    public string? OrgName { get; set; }

    public string? Apiurl { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? SenderId { get; set; }

    public string? Deleteflag { get; set; }

    public string? OwnerMobileNo { get; set; }
}
