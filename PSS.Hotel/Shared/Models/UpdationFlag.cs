using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class UpdationFlag
{
    public string? PhysicalLiquor { get; set; }

    public string? CounterCashier { get; set; }

    public string? FoodStockSetting { get; set; }

    public string? OpeningStockFlag { get; set; }

    public string? TotalBackupFlag { get; set; }

    public string? CaptainPadFlag { get; set; }

    public string? DataSendSecondDefine { get; set; }

    public string? CashMemoGeneration { get; set; }

    public string? TempDbcreateFlag { get; set; }
}
