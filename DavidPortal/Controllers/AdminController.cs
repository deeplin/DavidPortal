using DavidCore.Abstract;
using DavidCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DavidPortal.Controllers
{
    public class AdminController : Controller
    {
        private IDeviceRepository deviceRepository;

        public AdminController(IDeviceRepository deviceRepository)
        {
            this.deviceRepository = deviceRepository;
        }

        public ViewResult Index()
        {
            return View(deviceRepository.Devices);
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
                TempData["message"] = string.Format("{0} has been saved", device.DeviceId);
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(device);
            }
        }

        public ViewResult Create()
        {
            return View("Edit", new Device());
        }

        [HttpPost]
        public ActionResult Delete(string deviceId)
        {
            Device device = deviceRepository.Delete(deviceId);
            if (device != null)
            {
                TempData["message"] = string.Format("{0} was deleted",
                    deviceId);
            }
            return RedirectToAction("Index");
        }
    }
}