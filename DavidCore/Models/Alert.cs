using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DavidCore.Models
{
    public class Alert
    {
        [Key]
        [Display(Name = "报告序号")]
        public int Id { get; set; }
        public string AlertId { get; set; }
        [Display(Name = "报告日期")]
        public string OccurTime { get; set; }
        [Display(Name = "报警内容")]
        public string AlertDetail { get; set; }
    }
}