namespace BitrateApi.Models
{
    public class NIC
    {
        public string Description { get; set; }
        public string MAC { get; set; }
        public DateTime Timestamp { get; set; }
        public ulong Rx { get; set; }
        public ulong Tx { get; set; }
    }
}
