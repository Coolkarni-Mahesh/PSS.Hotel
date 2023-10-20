namespace PSS.Hotel.Shared
{
    public class SupervisorScreenModel
    {
        public string? CaptainName { get; set; }
        public string? WaiterName { get; set; }
        public string? CustomerName { get; set; }
        public string? TableName { get; set; }
        public DateTime OrderedTime { get; set; }
        public string? ItemName { get; set; }
        public int PendingItemQty { get; set; }
        public int Delivered { get; set; }
    }
}
