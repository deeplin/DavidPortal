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
        private IReportRepository reportRepository;
        public MapController(IDeviceRepository deviceRepository, IReportRepository reportRepository)
        {
            this.deviceRepository = deviceRepository;
            this.reportRepository = reportRepository;
        }

        public ActionResult Index()
        {
            IList<DeviceReport> deviceReports = new List<DeviceReport>();
            IEnumerable<Device> devices = deviceRepository.Devices.OrderBy(device => device.DeviceId);

            foreach (Device device in devices)
            {
                List<Report> reports = reportRepository.Reports.Where(
                    report => device.DeviceId == report.DeviceId).ToList();
                if (reports.Count == 1)
                {
                    DeviceReport deviceReport = new DeviceReport();
                    deviceReport.device = device;
                    deviceReport.report = reports[0];
                    deviceReports.Add(deviceReport);
                }
            }
            return View(deviceReports);
        }
    }
}