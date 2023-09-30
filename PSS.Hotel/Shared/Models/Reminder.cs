using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class Reminder
{
    public int? Recordno { get; set; }

    public string? Title { get; set; }

    public DateTime? Rdate { get; set; }

    public DateTime? Rtime { get; set; }

    public string? Description { get; set; }
}
