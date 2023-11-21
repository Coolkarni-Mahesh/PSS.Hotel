namespace PSS.Hotel.Shared;

public class ItemwiseModel
{
    public int? DailyTableDetailID { get; set; }
    public string? TableName { get; set; }
    public int? KotNo { get; set; }
    public string? CaptainName { get; set; }
    public string? WaiterName { get; set; }
    public string? CustomerName { get; set; }
    public DateTime StartTime { get; set; }
    public string? ItemName { get; set; }
    public string? KOTMessage { get; set; }
    public int NoOfPendingItem { get; set; }
    public int NoOfCookingItem { get; set; }
    public int NoOfCancelItem { get; set; }
    public int NoOfDeliveredItem { get; set; }   
    public int NoOfReadyItem { get; set; }
    public int? NoOfQuantity { get; set; }
}
