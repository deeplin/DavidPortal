using DavidCore.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DavidCore.Entities;

namespace DavidCore.Concrete
{
    public class EFHospitalRepository : IHospitalRepository
    {
        private DavidCloud davidCloud = new DavidCloud();

        public IEnumerable<Hospital> Hospitals
        {
            get { return davidCloud.Hospitals; }
        }

        public void Save(Hospital hospital)
        {
            Hospital dbEntry = davidCloud.Hospitals.Find(hospital.HospitalId);
            if (dbEntry != null)
            {
                dbEntry.HospitalId = hospital.HospitalId;
                dbEntry.HospitalAddress = hospital.HospitalAddress;
                dbEntry.contactName = hospital.contactName;
                dbEntry.contactPhone = hospital.contactPhone;
                dbEntry.contactMobile = hospital.contactMobile;
            }
            else
            {
                davidCloud.Hospitals.Add(hospital);
            }
            davidCloud.SaveChanges();
        }

        public Hospital Delete(int hospitalId)
        {
            Hospital dbEntry = davidCloud.Hospitals.Find(hospitalId);
            if (dbEntry != null)
            {
                davidCloud.Hospitals.Remove(dbEntry);
                davidCloud.SaveChanges();
            }
            return dbEntry;
        }
    }
}
