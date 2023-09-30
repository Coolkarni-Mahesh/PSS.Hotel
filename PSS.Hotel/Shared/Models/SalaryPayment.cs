using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class SalaryPayment
{
    public int? TransactionId { get; set; }

    public DateTime? Tdate { get; set; }

    public int? SrNo { get; set; }

    public DateTime? PaymentMoth { get; set; }

    public int? TransactionNo { get; set; }

    public int? Empno { get; set; }

    public int? Salary { get; set; }

    public int? PaySalary { get; set; }

    public int? Advance { get; set; }

    public int? OtherDed { get; set; }

    public int? NetPay { get; set; }

    public int? CreditId { get; set; }
}
