﻿using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TempOnlineExUnitWiseOpening
{
    public int? RawitemId { get; set; }

    public string? RawItem { get; set; }

    public int? Unitcode { get; set; }

    public int? CaseQty { get; set; }

    public string? ExciseItemCode { get; set; }

    public string? Unit { get; set; }

    public int? Ml { get; set; }

    public int? Quantity { get; set; }

    public int? ExciseGroupId { get; set; }

    public DateTime? SearchDate { get; set; }
}
