using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class Datum
{
    public string? Name { get; set; }

    public string? Add1 { get; set; }

    public string? Add2 { get; set; }

    public string? SubName { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? PhoneNo { get; set; }

    public string? Vat { get; set; }

    public string? Orgname { get; set; }

    public string? LicenceNo { get; set; }

    public string? FoodLicNo { get; set; }

    public string? CounterCashierPrinterName { get; set; }

    public string? FoodVatNo { get; set; }

    public string? LodgeDatabaseName { get; set; }

    public string? ServiceTaxNo { get; set; }

    public string? Prefix { get; set; }

    public DateTime? BackupDate { get; set; }

    public DateTime? TotalBackUpDate { get; set; }

    public string? ExciseOrgname { get; set; }

    public string? ExciseExportFileName { get; set; }

    public string? ExciseExportFilePath { get; set; }

    public string? LodgeId { get; set; }

    public string? QrpathSetForCaptainTab { get; set; }

    public int? OrgCodeForSms { get; set; }

    public string? SendBillSmsurl { get; set; }
}
