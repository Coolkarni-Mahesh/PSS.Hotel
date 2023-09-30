using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class DbillFood
{
    public short? DbillNo { get; set; }

    public short? Itemcode { get; set; }

    public short? Srno { get; set; }

    public short? Orderqty { get; set; }

    public float? Rate { get; set; }

    public float? GstRate { get; set; }
}
