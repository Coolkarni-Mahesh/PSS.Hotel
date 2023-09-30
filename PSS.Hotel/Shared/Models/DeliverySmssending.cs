using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class DeliverySmssending
{
    public int? TransNo { get; set; }

    public int? Pbillcode { get; set; }

    public DateTime? Tdate { get; set; }

    public string BillType { get; set; } = null!;

    public int? Customercode { get; set; }

    public string? MobileNo { get; set; }

    public string? SendingStatus { get; set; }

    public int? Usercode { get; set; }
}
