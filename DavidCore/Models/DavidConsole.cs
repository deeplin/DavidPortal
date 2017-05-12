using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DavidCore.Models
{
    public class DavidConsole
    {
        [Key]
        [Display(Name = "设备序号")]
        [MaxLength(1024)]
        public String DavidConsoleId
        {
            get; set;
        }
        public string User
        {
            get; set;
        }

        public string Password
        {
            get; set;
        }

        [Required(ErrorMessage = "请输入设备型号")]
        [Display(Name = "设备型号")]
        [MaxLength(64)]
        public string DeviceModel
        {
            get; set;
        }
        [Display(Name = "生产厂商")]
        public string Manufacture
        {
            get; set;
        }
        [Display(Name = "生产日期")]
        public string ManufactureDate
        {
            get; set;
        }
        [Display(Name = "登陆时间")]
        public String LoginTime
        {
            get; set;
        }

        public DateTime HeartBeatTime { get; set; }

        public BaiduLocation BaiduLocation { get; set; }

        public String TokenBase64 { get; set; }

        [Display(Name = "医院")]
        public Hospital Hospital { get; set; }

        public Alert Alert { get; set; }

        public Analog Analog { get; set; }
    }
}