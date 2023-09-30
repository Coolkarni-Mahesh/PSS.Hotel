﻿using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class OwnerDepositDetail
{
    public int? TransactionId { get; set; }

    public int? Srno { get; set; }

    public string? DepositorName { get; set; }

    public float? Amount { get; set; }

    public DateTime? Tdate { get; set; }

    public string? Remark { get; set; }
}
