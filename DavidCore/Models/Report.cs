using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DavidCore.Models
{
    public class Report
    {
        public string ReportId { get; set; }

        public string DeviceId { get; set; }

        public DateTime UpdateTime { get; set; }

        public double SkinTemperature { get; set; }

        public double BoxTemperature { get; set; }
        public double Humidity { get; set; }
        public double Weight { get; set; }

        public double Oxygen { get; set; }
    }
}