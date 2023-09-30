using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class FbquestionMaster
{
    public int? Qid { get; set; }

    public string? Question { get; set; }

    public string? Opt1 { get; set; }

    public string? Opt2 { get; set; }

    public string? Opt3 { get; set; }

    public string? Opt4 { get; set; }

    public string? Opt5 { get; set; }

    public string? OptionAllow { get; set; }

    public string? DeleteFlag { get; set; }
}
