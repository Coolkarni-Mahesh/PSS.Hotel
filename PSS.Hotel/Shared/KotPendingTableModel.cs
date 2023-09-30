namespace PSS.Hotel.Shared;

public class KotPendingTableModel
{
    public int Id { get; set; }
    public string? TableName { get; set; }
    public int TotalItemQty { get; set; }
    public int ReadyItemQty { get; set; }
    public int PendingItemQty { get; set; }
    public int CancelItemQty { get; set; }
    public int DeliveredItemQty { get; set; }

}
