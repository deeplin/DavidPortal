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
    }
}
