using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ExpiryBeerItemsDetailReport
{
    public int? Pbillcode { get; set; }

    public int? ItemGroupCode { get; set; }

    public int? BeerExpiryDays { get; set; }

    public float? Qty { get; set; }

    public string? BillNo { get; set; }

    public DateTime? Pdate { get; set; }

    public string? BatchNo { get; set; }

    public DateTime? BeerMfgdate { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string? RawItem { get; set; }

    public string? Unit { get; set; }
}
