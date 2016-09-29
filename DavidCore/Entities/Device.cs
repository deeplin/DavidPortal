using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DavidCore.Entities
{
    public class Device
    {
        [Key]
        [Display(Name = "设备序号")]
        [MaxLength(64)]
        public string DeviceId { get; set; }

        [Required(ErrorMessage = "请输入设备型号")]
        [Display(Name = "设备型号")]
        [MaxLength(64)]
        public string Model { get; set; }

        [Display(Name = "生产日期")]
        public DateTime? ProductionDate { get; set; }

        [Display(Name = "网络地址")]
        [MaxLength(32, ErrorMessage ="请输入IPV4地址")]
        public string NatIP { get; set; }

        [Display(Name = "网络端口")]
        public int? NatPort { get; set; }

        [Display(Name = "纬度")]
        public double? Latitude { get; set; }

        [Display(Name = "经度")]
        public double? Longitude { get; set; }

        [Display(Name = "定位误差")]
        public float? Radius { get; set; }

        [Display(Name = "设备地址")]
        [MaxLength(1024)]
        public string LocationAddress { get; set; }

        [Display(Name = "地址描述")]
        [MaxLength(1024)]
        public string LocationDescribe { get; set; }
        
        [Display(Name = "医院")]
        public Hospital Hospital{ get; set; }
    }
}