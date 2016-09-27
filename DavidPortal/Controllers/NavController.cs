using DavidCore.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DavidPortal.Controllers
{
    public class NavController : Controller
    {
        private IDeviceRepository deviceRepository;

        public NavController(IDeviceRepository deviceRepository)
        {
            this.deviceRepository = deviceRepository;
        }

        public PartialViewResult Menu(string model = null)
        {

            ViewBag.SelectedModel = model;

            IEnumerable<string> models = deviceRepository.Devices
                                    .Select(x => x.Model)
                                    .Distinct()
                                    .OrderBy(x => x);

            return PartialView(models);
        }
    }
}