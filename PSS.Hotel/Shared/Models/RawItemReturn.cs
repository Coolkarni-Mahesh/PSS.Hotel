using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class RawItemReturn
{
    public int? ReturnId { get; set; }

    public DateTime? Idate { get; set; }

    public int? Empno { get; set; }

    public int? Departmentcode { get; set; }

    public string? Remark { get; set; }
}
