using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

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
        [Display(Name = "设备序号")]
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
        [Required(ErrorMessage = "请输入设备型号")]
        [Display(Name = "设备型号")]
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
        [Display(Name = "生产日期")]
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
        [Display(Name = "网络地址")]
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
        [Display(Name = "网络端口")]
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
        [Display(Name = "纬度")]
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
        [Display(Name = "经度")]
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
        [Display(Name = "定位误差")]
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
        [Required(ErrorMessage = "请输入设备地址")]
        [Display(Name = "设备地址")]
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
        [Display(Name = "地址描述")]
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