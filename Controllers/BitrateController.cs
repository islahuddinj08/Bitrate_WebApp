using Microsoft.AspNetCore.Mvc;
using BitrateApi.Models;

namespace BitrateApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BitrateController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetBitrateSample()
        {
            var deviceData = new DeviceData
            {
                Device = "Arista",
                Model = "X-Video",
                NIC = new List<NIC>
                {
                    new NIC
                    {
                        Description = "Linksys ABR",
                        MAC = "14:91:82:3C:D6:7D",
                        Timestamp = DateTime.Parse("2020-03-23T18:25:43.511Z"),
                        Rx = 3698574500,
                        Tx = 122558800
                    }
                }
            };

            return Ok(deviceData);
        }
    }
}
