namespace BitrateApi.Models
{
    public class DeviceData
    {
        public string Device { get; set; }
        public string Model { get; set; }
        public List<NIC> NIC { get; set; }
    }
}
