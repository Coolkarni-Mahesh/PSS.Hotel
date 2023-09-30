using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CreditEntry
{
    public int? Transcod { get; set; }

    public int? SupplierCode { get; set; }

    public DateTime? Date { get; set; }

    public string? ReferenceNo { get; set; }

    public float? Amount { get; set; }

    public string? Remark { get; set; }

    public string? DeletionAllow { get; set; }
}
