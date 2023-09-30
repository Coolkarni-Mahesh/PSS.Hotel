using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class ShortcutNameMaster
{
    public string? Ttype { get; set; }

    public int? SrNo { get; set; }

    public int? MainId { get; set; }

    public string? ShortcutName { get; set; }

    public string? ShortcutType { get; set; }

    public string? ShortCutKey { get; set; }

    public int? KeyCode { get; set; }

    public int? Shift { get; set; }

    public int? RowHeight { get; set; }

    public string? ShortcutPresentIn { get; set; }
}
