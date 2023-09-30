using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CutomerWisePaymentDetailMess
{
    public DateTime? Tdate { get; set; }

    public string? Name { get; set; }

    public float? Amount { get; set; }

    public string? CashType { get; set; }

    public int? CoupanQty { get; set; }

    public int? ValidDays { get; set; }

    public string? Remark { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }
}
