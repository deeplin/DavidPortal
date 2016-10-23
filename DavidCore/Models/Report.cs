using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DavidCore.Models
{
    public class Report
    {
        [Key]
        [Display(Name = "报告序号")]
        [MaxLength(64)]
        public string ReportId { get; set; }
        [Required(ErrorMessage = "请输入设备序号")]
        [Display(Name = "设备序号")]
        [MaxLength(64)]
        public string DeviceId { get; set; }
        [Display(Name = "报告日期")]
        public DateTime? UpdateTime { get; set; }
        [Display(Name = "肤温")]
        public int? SkinTemperature { get; set; }
        [Display(Name = "箱温")]
        public int? BoxTemperature { get; set; }
        [Display(Name = "湿度")]
        public int? Humidity { get; set; }
        [Display(Name = "氧气")]
        public int? Oxygen { get; set; }
        [Display(Name = "重量")]
        public int? Weight { get; set; }
    }
}