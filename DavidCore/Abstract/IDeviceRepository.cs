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
        IEnumerable<DavidConsole> Devices { get; }

        void Save(DavidConsole davidConsole);

        DavidConsole Delete(string deviceId);
    }
}
