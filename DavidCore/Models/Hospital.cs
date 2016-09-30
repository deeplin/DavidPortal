using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidCore.Models
{
    public class Hospital
    {
        [Key]
        public int HospitalId { get; set; }
        [Required(ErrorMessage = "请输入医院名称")]
        [Display(Name = "医院名称")]
        [MaxLength(256)]
        public string HospitalName { get; set; }

        [Display(Name = "医院地址")]
        [MaxLength(1024)]
        public string HospitalAddress { get; set; }

        [Display(Name = "联系人姓名")]
        [MaxLength(32)]
        public string contactName { get; set; }

        [Display(Name = "联系人电话")]
        [MaxLength(32)]
        public string contactPhone { get; set; }

        [Display(Name = "联系人手机")]
        [MaxLength(32)]
        public string contactMobile { get; set; }
    }
}
