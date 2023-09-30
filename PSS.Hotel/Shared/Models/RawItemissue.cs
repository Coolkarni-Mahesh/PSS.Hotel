using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class RawItemissue
{
    public int? IssueId { get; set; }

    public DateTime? Idate { get; set; }

    public int? Empno { get; set; }

    public int? Departmentcode { get; set; }

    public string? Remark { get; set; }
}
