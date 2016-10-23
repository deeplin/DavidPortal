using DavidCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DavidPortal.Models
{
    public class DeviceReport
    {
        public Device device { get; set; }

        public Report report { get; set; }
    }
}