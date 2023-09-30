using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class KotstyleMaster
{
    public int? KotstyleId { get; set; }

    public string? Kotstyle { get; set; }

    public string? Description { get; set; }

    public string? DeleteFlag { get; set; }
}
