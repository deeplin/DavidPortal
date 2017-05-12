using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidCore.Models
{
    public class BaiduLocation
    {
        [Display(Name = "纬度")]
        public double? Latitude { get; set; }
        [Display(Name = "经度")]
        public double? Longitude { get; set; }
        [Display(Name = "定位误差")]
        public float? Radius { get; set; }
        [Display(Name = "设备地址")]
        public string Address { get; set; }
        [Display(Name = "地址描述")]
        public string Describe { get; set; }
    }
}
