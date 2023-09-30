using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class DepartmentMaster
{
    public int? Departmentcode { get; set; }

    public string? Department { get; set; }

    public string? Deleteflag { get; set; }

    public string? PrinterName { get; set; }

    public int? SectionId { get; set; }

    public string? CounterPrinterName { get; set; }
}
