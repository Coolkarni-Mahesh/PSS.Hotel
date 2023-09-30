using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class UserDefineAlert
{
    public int? Tid { get; set; }

    public string? AlertSubject { get; set; }

    public string? Description { get; set; }

    public DateTime? AlertDate { get; set; }

    public string? Deleteflag { get; set; }
}
