using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSS.Hotel.Shared.Models;

public partial class DailyTable
{
   

    public int? Holdno { get; set; }

    public DateTime? Tdate { get; set; }

    public int? Customercode { get; set; }

    public string? CustName { get; set; }

   
    public int? Persons { get; set; }

    public string? StartTime { get; set; }

    public int? WetterCode { get; set; }

    public int? CoupanId { get; set; }


    public int? CaptainCode { get; set; }
    [ForeignKey("CaptainCode")]
    public EmployeeMaster? employeeMaster { get; set; }

    public int? TableId { get; set; }
    //[ForeignKey("TableId")]
    //public TableName? TableName { get; set; }
}
