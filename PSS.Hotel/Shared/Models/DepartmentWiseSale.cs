using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class DepartmentWiseSale
{
    public int? Tid { get; set; }

    public DateTime? Tdate { get; set; }

    public int? Empno { get; set; }

    public int? Departmentcode { get; set; }

    public string? Remark { get; set; }
}
