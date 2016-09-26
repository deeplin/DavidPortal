using DavidCore.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DavidPortal.Controllers
{
    public class DeviceController : Controller
    {
        IDeviceRepository deviceRepository;
        public DeviceController(IDeviceRepository deviceRepository)
        {
            this.deviceRepository = deviceRepository;
        }

        // GET: Device
        public ActionResult Index()
        {
            return View(deviceRepository.Devices);
        }
    }
}