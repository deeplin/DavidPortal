using DavidCore.Abstract;
using DavidCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidCore.Concrete
{
    public class EFDeviceRepository : IDeviceRepository
    {
        private DavidCloud davidCloud = new DavidCloud();

        public IEnumerable<Device> Devices
        {
            get { return davidCloud.Devices; }
        }

        public void Save(Device device)
        {
            Device dbEntry = davidCloud.Devices.Find(device.DeviceId);
            if (dbEntry != null)
            {
                dbEntry.DeviceId = device.DeviceId;
                dbEntry.Model = device.Model;
                dbEntry.ProductionDate = device.ProductionDate;
                dbEntry.NatIP = device.NatIP;
                dbEntry.NatPort = device.NatPort;
                dbEntry.Latitude = device.Latitude;
                dbEntry.Longitude = device.Longitude;
                dbEntry.Radius = device.Radius;
                dbEntry.LocationAddress = device.LocationAddress;
                dbEntry.LocationDescribe = device.LocationDescribe;
            }else
            {
                davidCloud.Devices.Add(device);
            }
            davidCloud.SaveChanges();
        }

        public Device Delete(string deviceId)
        {
            Device dbEntry = davidCloud.Devices.Find(deviceId);
            if (dbEntry != null)
            {
                davidCloud.Devices.Remove(dbEntry);
                davidCloud.SaveChanges();
            }
            return dbEntry;
        }
    }
}
