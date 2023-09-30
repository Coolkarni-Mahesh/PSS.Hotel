using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TodaysParcelDeliveryReport
{
    public int? TransNo { get; set; }

    public int? Pbillcode { get; set; }

    public DateTime? Tdate { get; set; }

    public string? BillType { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? CaptainName { get; set; }

    public int? PaidAmt { get; set; }

    public double? NetAmt { get; set; }

    public string? ParcelTable { get; set; }

    public int? CaptainCode { get; set; }
}
