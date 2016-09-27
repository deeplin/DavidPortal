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
        public ActionResult List(string model, int page = 1)
        {
            DeviceListView deviceListView = new DeviceListView
            {
                Devices = deviceRepository.Devices
                .Where(device => model == null || device.Model == model)
                .OrderBy(device => device.DeviceId)
                .Skip((page - 1) * pageSize)
                .Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = model == null ?
                        deviceRepository.Devices.Count() :
                        deviceRepository.Devices.Where(e => e.Model == model).Count()
                },
                CurrentModel = model
            };

            return View(deviceListView);
        }
    }
}