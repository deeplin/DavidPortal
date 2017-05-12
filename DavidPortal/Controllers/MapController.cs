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
    public class MapController : Controller
    {
        private IDeviceRepository deviceRepository;
        public MapController(IDeviceRepository deviceRepository)
        {
            this.deviceRepository = deviceRepository;
        }

        public ActionResult Index()
        {
            IEnumerable<DavidConsole> davidConsoles = deviceRepository.Devices.OrderBy
                (DavidConsole => DavidConsole.DavidConsoleId);
            return View(davidConsoles);
        }
    }
}