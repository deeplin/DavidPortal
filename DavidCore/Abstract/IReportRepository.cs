using DavidCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidCore.Abstract
{
    public interface IReportRepository
    {
        IEnumerable<Report> Reports { get; }
    }
}
