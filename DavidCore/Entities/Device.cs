using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DavidCore.Entities
{
    public class Device
    {
        private string deviceId;
        private string model;
        private DateTime productionDate;
        private string natIP;
        private int natPort;
        private double latitude;
        private double longitude;
        private float radius;
        private string locationAddress;
        private string locationDescribe;
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
        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }
        public DateTime ProductionDate
        {
            get
            {
                return productionDate;
            }

            set
            {
                productionDate = value;
            }
        }
        public string NatIP
        {
            get
            {
                return natIP;
            }

            set
            {
                natIP = value;
            }
        }
        public int NatPort
        {
            get
            {
                return natPort;
            }

            set
            {
                natPort = value;
            }
        }
        public double Latitude
        {
            get
            {
                return latitude;
            }

            set
            {
                latitude = value;
            }
        }
        public double Longitude
        {
            get
            {
                return longitude;
            }

            set
            {
                longitude = value;
            }
        }
        public float Radius
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
            }
        }
        public string LocationAddress
        {
            get
            {
                return locationAddress;
            }

            set
            {
                locationAddress = value;
            }
        }
        public string LocationDescribe
        {
            get
            {
                return locationDescribe;
            }

            set
            {
                locationDescribe = value;
            }
        }
    }
}