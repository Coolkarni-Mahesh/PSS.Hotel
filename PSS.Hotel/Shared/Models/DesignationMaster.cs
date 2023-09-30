using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class DesignationMaster
{
    public int? DesignationCode { get; set; }

    public string? Designation { get; set; }

    public int? Hodcode { get; set; }

    public string? Deleteflag { get; set; }

    public int? Usercode { get; set; }
}
