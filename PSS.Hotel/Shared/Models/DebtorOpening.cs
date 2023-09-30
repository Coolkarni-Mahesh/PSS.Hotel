using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class DebtorOpening
{
    public int? Transcod { get; set; }

    public int? CustomerCode { get; set; }

    public DateTime? Date { get; set; }

    public float? Amount { get; set; }

    public string? Remark { get; set; }

    public string? DeletionAllow { get; set; }

    public int? Departmentcode { get; set; }
}
