using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class TempTableRoom
{
    public int? TableId { get; set; }

    public string? TableName { get; set; }

    public int? RoomNo { get; set; }

    public string? RoomName { get; set; }
}
