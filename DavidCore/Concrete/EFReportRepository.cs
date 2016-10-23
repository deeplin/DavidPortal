using DavidCore.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DavidCore.Models;

namespace DavidCore.Concrete
{
    public class EFReportRepository : IReportRepository
    {

        private DavidCloud davidCloud = new DavidCloud();

        public IEnumerable<Report> Reports
        {
            get
            {
                return davidCloud.Reports;
            }
        }
    }
}
