using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS.Hotel.Shared;

public class DailyTableDetail_DTO
{
    public string? TableName { get; set; }
    public int? KotNo { get; set; }
    public string? ItemName { get; set; }
    public string? KOTMsg { get; set; }
    public DateTime StartTime { get; set; }
    public int Delivered { get; set; }
    public int Pending { get; set; }
    public int Ready { get; set; }
    public int Cooking { get; set; }
    public int Cancel { get; set; }
}
