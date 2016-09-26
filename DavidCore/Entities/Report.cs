using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DavidCore.Entities
{
    public class Report
    {
        private string reportId;
        private string deviceId;
        private DateTime updateTime;
        private double skinTemperature;
        private double boxTemperature;
        private double humidity;
        private double oxygen;
        private double weight;

        public string ReportId
        {
            get
            {
                return reportId;
            }

            set
            {
                reportId = value;
            }
        }

        public string DeviceId
        {
            get
            {
                return deviceId;
            }

            set
            {
                deviceId = value;
            }
        }

        public DateTime UpdateTime
        {
            get
            {
                return updateTime;
            }

            set
            {
                updateTime = value;
            }
        }

        public double SkinTemperature
        {
            get
            {
                return skinTemperature;
            }

            set
            {
                skinTemperature = value;
            }
        }

        public double BoxTemperature
        {
            get
            {
                return boxTemperature;
            }

            set
            {
                boxTemperature = value;
            }
        }

        public double Humidity
        {
            get
            {
                return humidity;
            }

            set
            {
                humidity = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }

        public double Oxygen
        {
            get
            {
                return oxygen;
            }

            set
            {
                oxygen = value;
            }
        }
    }
}