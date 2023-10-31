using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSS.Hotel.Shared.Models;

public partial class DailyTableDetail
{
    public int? Srno { get; set; }

    public int? TableNo { get; set; }

   

    public int? Order { get; set; }

    public int? Unitcode { get; set; }

    public float? Cancel { get; set; }

    public float? Rate { get; set; }

    public float? SnacksRate { get; set; }

    public string? Kotbot { get; set; }

    public int? KotNo { get; set; }

    public string? Stockded { get; set; }

    public float? ActualRate { get; set; }

    public string? StartTime { get; set; }

    public string? Kotmsg { get; set; }

    public int Ready { get; set; }
    public int Pending { get; set; }
    public int Delivered { get; set; }
    public int Cooking { get; set; }

    [ForeignKey("Itemcode")]
    public ItemMaster? itemMaster { get; set; }
    
    public int? Itemcode { get; set; }

   

}
