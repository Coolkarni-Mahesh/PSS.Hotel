using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CustomerInformationReport
{
    public int? Customercode { get; set; }

    public string? Name { get; set; }

    public string? CustomerType { get; set; }

    public string? Address { get; set; }

    public string? Cityname { get; set; }

    public string? Phone { get; set; }

    public string? PermitNo { get; set; }

    public DateTime? Validupto { get; set; }

    public string? Deleteflag { get; set; }

    public DateTime? Dob { get; set; }

    public string? FavouriteDish { get; set; }
}
