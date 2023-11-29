using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSS.Hotel.Shared.Models;

public partial class EmployeeMaster
{
    public int? Empno { get; set; }

   
    public string? Firstname { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Pradd { get; set; }

    public int? Prcitycode { get; set; }

    public string? Prphoneno { get; set; }

    public DateTime? Dob { get; set; }

    public string? Qualification { get; set; }

    public DateTime? DoJ { get; set; }

    public DateTime? Dol { get; set; }

    public int? Salary { get; set; }

    public int? GrossSalary { get; set; }

    public string? Remark { get; set; }

    public string? Deleteflag { get; set; }

    public string? EmpId { get; set; }
    [Required(ErrorMessage = "* User name is requred")]
    public string? AliasName { get; set; }
    [Required(ErrorMessage = "* Password is requred")]
    public string? Password { get; set; }

    public string? AdminFlag { get; set; }

    public int? LoggedIn { get; set; }

    public string? TabDataAllow { get; set; }

    public int? CommissionBoundary { get; set; }


    public int? Designationcode { get; set; }
    [ForeignKey("Designationcode")]
    public DesignationMaster? DesignationMaster { get; set; }
}
