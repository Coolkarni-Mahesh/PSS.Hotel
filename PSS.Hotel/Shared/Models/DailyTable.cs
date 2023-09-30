using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class DailyTable
{
    public int? TableId { get; set; }

    public int? Holdno { get; set; }

    public DateTime? Tdate { get; set; }

    public int? Customercode { get; set; }

    public string? CustName { get; set; }

    public int? CaptainCode { get; set; }

    public int? Persons { get; set; }

    public string? StartTime { get; set; }

    public int? WetterCode { get; set; }

    public int? CoupanId { get; set; }
}
