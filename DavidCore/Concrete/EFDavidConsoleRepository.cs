using DavidCore.Abstract;
using DavidCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidCore.Concrete
{
    public class EFDavidConsoleRepository : IDeviceRepository
    {
        private DavidCloud davidCloud = new DavidCloud();

        public IEnumerable<DavidConsole> Devices
        {
            get { return davidCloud.DavidConsoles; }
        }

        public void Save(DavidConsole davidConsole)
        {
            DavidConsole dbEntry = davidCloud.DavidConsoles.Find(davidConsole.DavidConsoleId);
            if (dbEntry != null)
            {
                dbEntry.DavidConsoleId = davidConsole.DavidConsoleId;
                dbEntry.User = davidConsole.User;
                dbEntry.Password = davidConsole.Password;
                dbEntry.DeviceModel = davidConsole.DeviceModel;
                dbEntry.Manufacture = davidConsole.Manufacture;
                dbEntry.ManufactureDate = davidConsole.ManufactureDate;
                dbEntry.LoginTime = davidConsole.LoginTime;
                dbEntry.HeartBeatTime = davidConsole.HeartBeatTime;
                dbEntry.BaiduLocation = davidConsole.BaiduLocation;
                dbEntry.Hospital = davidConsole.Hospital;
                dbEntry.Alert = davidConsole.Alert;
            }else
            {
                davidCloud.DavidConsoles.Add(davidConsole);
            }
            davidCloud.SaveChanges();
        }

        public DavidConsole Delete(string deviceId)
        {
            DavidConsole dbEntry = davidCloud.DavidConsoles.Find(deviceId);
            if (dbEntry != null)
            {
                davidCloud.DavidConsoles.Remove(dbEntry);
                davidCloud.SaveChanges();
            }
            return dbEntry;
        }
    }
}
