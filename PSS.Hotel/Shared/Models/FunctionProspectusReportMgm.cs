using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class FunctionProspectusReportMgm
{
    public int? TransactionId { get; set; }

    public DateTime? Tdate { get; set; }

    public int? FunctionTypeId { get; set; }

    public string? FunctionType { get; set; }

    public int? HallId { get; set; }

    public string? Hall { get; set; }

    public DateTime? FromDate { get; set; }

    public string? FromDateTime { get; set; }

    public DateTime? ToDate { get; set; }

    public string? ToDateTime { get; set; }

    public int? ExpectedPax { get; set; }

    public int? MinimumGuaranteed { get; set; }

    public int? CustomerId { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? ContactName { get; set; }

    public float? AdvanceAmount { get; set; }

    public string? RectNo { get; set; }

    public DateTime? RectDate { get; set; }

    public string? Telephone { get; set; }

    public float? RatePerPax { get; set; }

    public float? HallRent { get; set; }

    public string? Foinstr { get; set; }

    public string? Hkinstr { get; set; }

    public string? Stores { get; set; }

    public string? Layout { get; set; }

    public string? Equipment { get; set; }

    public string? Maintain { get; set; }

    public string? Fbinstr { get; set; }

    public float? AddOther { get; set; }

    public float? DeductOther { get; set; }

    public string? PaymentType { get; set; }

    public string? BankName { get; set; }

    public DateTime? ChequeDate { get; set; }

    public string? ChequeNo { get; set; }

    public float? NetAmount { get; set; }

    public string? Remark { get; set; }

    public int? UserCode { get; set; }

    public string? Username { get; set; }

    public int? SrNo { get; set; }

    public string? MenuType { get; set; }

    public string? TdateTime { get; set; }

    public float? Pax { get; set; }

    public float? Amount { get; set; }

    public int? SubSrNo { get; set; }

    public float? Qty { get; set; }

    public float? Rate { get; set; }

    public DateTime? TdateDetail { get; set; }

    public string? GroupName { get; set; }

    public string? ItemName { get; set; }

    public string? CateringManager { get; set; }

    public string? FlowOfEvent { get; set; }
}
