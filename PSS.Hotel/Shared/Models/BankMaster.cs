using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class BankMaster
{
    public int? BankCode { get; set; }

    public string? BankName { get; set; }

    public string? Address { get; set; }

    public int? Citycode { get; set; }

    public string? Phone { get; set; }

    public string? Deleteflag { get; set; }
}
