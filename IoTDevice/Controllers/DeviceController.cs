using IoTDevice.Database;
using IoTDevice.Models;
using IoTDevice.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IoTDevice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceRepository deviceRepository;

        public DeviceController(IoTDeviceDBContext dBContext)
        {
            deviceRepository = new DeviceRepository(dBContext);
        }

        [HttpGet]
        public async Task<IActionResult> GetDevices()
        {
            var result = await deviceRepository.GetDevices();
            return new OkObjectResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddDevice(Device device)
        {
            await deviceRepository.AddDevice(device);
            return Ok();
        }
    }
}
