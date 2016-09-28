using DavidCore.Abstract;
using DavidCore.Entities;
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
        private int pageSize = 2;
        public DeviceController(IDeviceRepository deviceRepository)
        {
            this.deviceRepository = deviceRepository;
        }

        // GET: Device
        public ActionResult Index(int page = 1)
        {
            DeviceListView deviceListView = new DeviceListView
            {
                Devices = deviceRepository.Devices
                .OrderBy(device => device.DeviceId)
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

        public ViewResult Create()
        {
            return View("Edit", new Device());
        }

        public ViewResult Edit(string deviceId)
        {
            Device device = deviceRepository.Devices
                .FirstOrDefault(d => d.DeviceId == deviceId);
            return View(device);
        }

        [HttpPost]
        public ActionResult Edit(Device device)
        {
            if (ModelState.IsValid)
            {
                deviceRepository.Save(device);
                TempData["message"] = string.Format("{0} 已经保存", device.DeviceId);
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(device);
            }
        }
    }
}