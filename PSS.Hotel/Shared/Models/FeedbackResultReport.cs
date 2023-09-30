using System;
using System.Collections.Generic;

namespace PSS.Hotel.Shared.Models;

public partial class FeedbackResultReport
{
    public DateTime? Tdate { get; set; }

    public int? TableId { get; set; }

    public string? TableName { get; set; }

    public int? Qid { get; set; }

    public string? Question { get; set; }

    public string? Result { get; set; }

    public int? Customercode { get; set; }

    public string? Name { get; set; }
}
