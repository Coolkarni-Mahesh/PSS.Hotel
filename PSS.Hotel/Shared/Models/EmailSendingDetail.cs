using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class EmailSendingDetail
{
    public DateTime? Tdate { get; set; }

    public string? SendFlag { get; set; }

    public string? Ftype { get; set; }

    public string? FileName { get; set; }

    public string? GroupType { get; set; }
}
