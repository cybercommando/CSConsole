using IoTDevice.Database;
using IoTDevice.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IoTDevice.Repository
{
    public class DeviceRepository : IDeviceRepository
    {
        private readonly IoTDeviceDBContext ioTDeviceDBContext;
        public DeviceRepository(IoTDeviceDBContext dBContext)
        {
            ioTDeviceDBContext = dBContext;
        }

        public async Task AddDevice(Device device)
        {
            if (device != null)
            {
                await ioTDeviceDBContext.devices.AddAsync(device);
                await ioTDeviceDBContext.SaveChangesAsync();
            }
        }

        public async Task DeleteDevice(int id)
        {
            var device = await ioTDeviceDBContext.devices.FindAsync(id);
            if (device != null)
            {
                ioTDeviceDBContext.devices.Remove(device);
                await ioTDeviceDBContext.SaveChangesAsync();
            }
        }

        public async Task<Device> GetDevice(int id)
        {
            return await ioTDeviceDBContext.devices.FindAsync(id);
        }

        public async Task<IEnumerable<Device>> GetDevices()
        {
            return await ioTDeviceDBContext.devices.ToListAsync();
        }

        public async Task UpdateDevice(Device device)
        {
            ioTDeviceDBContext.Update(device);
            await ioTDeviceDBContext.SaveChangesAsync();
        }
    }
}
