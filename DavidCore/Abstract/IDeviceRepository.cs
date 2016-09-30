using DavidCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidCore.Abstract
{
    public interface IDeviceRepository
    {
        IEnumerable<Device> Devices { get; }

        void Save(Device device);

        Device Delete(string deviceId);
    }
}
