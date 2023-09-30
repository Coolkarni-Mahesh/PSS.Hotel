using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class Supplierinfo
{
    public int? SupplierCode { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public int? Citycode { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Remark { get; set; }

    public string? Deleteflag { get; set; }

    public string? Gstno { get; set; }
}
