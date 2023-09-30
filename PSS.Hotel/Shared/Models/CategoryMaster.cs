using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CategoryMaster
{
    public int? CategoryCode { get; set; }

    public string? CategoryName { get; set; }

    public string? Deleteflag { get; set; }
}
