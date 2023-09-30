using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TempPresentyDefine
{
    public int? Srno { get; set; }

    public int? Empno { get; set; }

    public int? ShiftId { get; set; }

    public DateTime? InDate1 { get; set; }

    public DateTime? OutDate1 { get; set; }

    public DateTime? InDate2 { get; set; }

    public DateTime? OutDate2 { get; set; }

    public DateTime? TempInDate1 { get; set; }

    public DateTime? TempInDate2 { get; set; }
}
