using DavidCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidCore.Abstract
{
    public interface IHospitalRepository
    {
        IEnumerable<Hospital> Hospitals { get; }

        void Save(Hospital hospital);

        Hospital Delete(int hospitalId);
    }
}
