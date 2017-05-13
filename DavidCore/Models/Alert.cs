using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DavidCore.Models
{
    public class Alert
    {
        public string AlertName { get; set; }
        [Display(Name = "报告日期")]
        public string OccurTime { get; set; }
        [Display(Name = "报警内容")]
        public string AlertDetail { get; set; }
    }
}