using DavidCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DavidPortal.Models
{
    public class DeviceListView
    {
        public IEnumerable<Device> Devices { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}