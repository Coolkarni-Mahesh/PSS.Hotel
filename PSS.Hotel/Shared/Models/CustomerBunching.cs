using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class CustomerBunching
{
    public int? Transactionid { get; set; }

    public int? SubCustcode { get; set; }

    public int? UseCustcode { get; set; }
}
