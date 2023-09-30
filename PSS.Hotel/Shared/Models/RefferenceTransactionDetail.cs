using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class RefferenceTransactionDetail
{
    public string? CustName { get; set; }

    public string? Type { get; set; }

    public DateTime? Tdate { get; set; }

    public string? BillNo { get; set; }

    public int? TransactionNo { get; set; }

    public float? Amount { get; set; }

    public string? SrNo { get; set; }

    public string? ReferenceName { get; set; }
}
