using DavidCore.Abstract;
using DavidPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DavidPortal.Controllers
{
    public class DeviceController : Controller
    {
        private IDeviceRepository deviceRepository;
        private int pageSize = 1;
        public DeviceController(IDeviceRepository deviceRepository)
        {
            this.deviceRepository = deviceRepository;
        }

        // GET: Device
        public ActionResult List(int page = 1)
        {
            DeviceListView deviceListView = new DeviceListView
            {
                Devices = deviceRepository.Devices.OrderBy(device => device.DeviceId)
                .Skip((page - 1) * pageSize)
                .Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = deviceRepository.Devices.Count()
                }
            };

            return View(deviceListView);
        }
    }
}