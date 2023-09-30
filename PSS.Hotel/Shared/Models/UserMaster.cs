using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class UserMaster
{
    public int? Usercode { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Fydisplay { get; set; }

    public string? BillKot { get; set; }

    public int? ShowTotalSalesAmt { get; set; }

    public int? AllowCancelItem { get; set; }

    public string? CancelItemPassword { get; set; }

    public string? SalesBillModifyPassword { get; set; }

    public int? BackDatedPurchaseBillLock { get; set; }

    public string? StockDeletePassword { get; set; }

    public int? AllowDiscount { get; set; }

    public int? AllowTaxation { get; set; }

    public int? AllowBillSettelment { get; set; }

    public string? BillSettelmentPassword { get; set; }

    public int? SalesBillSalesShortcutLock { get; set; }

    public string? KotprintingPassword { get; set; }
}
