using DavidCore.Abstract;
using DavidCore.Models;
using DavidPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DavidPortal.Controllers
{
    [Authorize]
    public class DeviceController : Controller
    {
        private IDeviceRepository deviceRepository;
        private int pageSize = 3;

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
                .OrderBy(device => device.DavidConsoleId)
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
            return View("Edit", new DavidConsole());
        }

        public ViewResult Edit(string deviceId)
        {
            DavidConsole device = deviceRepository.Devices
                .FirstOrDefault(d => d.DavidConsoleId == deviceId);
            return View(device);
        }

        [HttpPost]
        public ActionResult Edit(DavidConsole device)
        {
            if (ModelState.IsValid)
            {
                deviceRepository.Save(device);
                TempData["message"] = string.Format("{0} 已经保存", device.DavidConsoleId);
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(device);
            }
        }

        public ActionResult Delete(string deviceId)
        {
            DavidConsole device = deviceRepository.Delete(deviceId);
            if (device != null)
            {
                TempData["message"] = string.Format("{0} 已经删除",
                    deviceId);
            }
            return RedirectToAction("Index");
        }
    }
}