using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CustomerInfo
{
    public int? Customercode { get; set; }

    public string? CardNo { get; set; }

    public int? UseCustcode { get; set; }

    public string? CustomerType { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public int? Citycode { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public DateTime? Dob { get; set; }

    public string? Email { get; set; }

    public DateTime? Childdob { get; set; }

    public DateTime? AnniversaryDate { get; set; }

    public int? DiscountFood { get; set; }

    public float? DiscountLiquer { get; set; }

    public string? PermitNo { get; set; }

    public DateTime? Validupto { get; set; }

    public string? Remark { get; set; }

    public string? Deleteflag { get; set; }

    public string? Lodgin { get; set; }

    public DateTime? SaleDate { get; set; }

    public float? SaleQtyInMl { get; set; }

    public string? LiquorType { get; set; }

    public string? FavouriteDish { get; set; }

    public int? Itemcode { get; set; }

    public string? Gst { get; set; }

    public string? Photpath { get; set; }

    public string? PaymentMode { get; set; }
}
