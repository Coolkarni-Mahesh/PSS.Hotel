using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ItemMaster
{
    public int? Itemcode { get; set; }

    public string? ItemId { get; set; }

    public int? UseId { get; set; }

    public int? DepartmentCode { get; set; }

    public int? Rawitemcode { get; set; }

    public int? ItemGroupCode { get; set; }

    public string? ItemName { get; set; }

    public int? Unitcode { get; set; }

    public float? SalesPrice { get; set; }

    public float? PurchasePrice { get; set; }

    public string? Description { get; set; }

    public string? Deleteflag { get; set; }

    public int? ExciseGroupId { get; set; }

    public int? LiquorTypeId { get; set; }

    public int? BeerExpiryDays { get; set; }

    public int? ItemAllowMachine { get; set; }

    public string? ItemShortName { get; set; }

    public int? CpgroupCode { get; set; }

    public DateTime? Tdate { get; set; }

    public int? TsmainGroupcode { get; set; }

    public int? TssubGroupcode { get; set; }

    public string? ItemImagePath { get; set; }
}
