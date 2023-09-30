using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CustomerCreditReportUser
{
    public string? Name { get; set; }

    public float? Amount { get; set; }

    public string? BillId { get; set; }

    public DateTime? Tdate { get; set; }

    public string? CustomerType { get; set; }

    public string? StartTime { get; set; }

    public string? Remark { get; set; }

    public string? CreditName { get; set; }
}
