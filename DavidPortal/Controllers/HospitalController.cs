using DavidCore.Abstract;
using DavidCore.Entities;
using DavidPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DavidPortal.Controllers
{
    [Authorize]
    public class HospitalController : Controller
    {
        private IHospitalRepository hospitalRepository;
        private int pageSize = 3;

        public HospitalController(IHospitalRepository hospitalRepository)
        {
            this.hospitalRepository = hospitalRepository;
        }


        // GET: Hospital
        public ActionResult Index(int page = 1)
        {
            HospitalListView hospitalListView = new HospitalListView
            {
                Hospitals = hospitalRepository.Hospitals
                .OrderBy(hospital => hospital.HospitalId)
                .Skip((page - 1) * pageSize)
                .Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = hospitalRepository.Hospitals.Count()
                }
            };
            return View(hospitalListView);
        }

        public ViewResult Create()
        {
            return View("Edit", new Hospital());
        }

        public ViewResult Edit(int hospitalId)
        {
            Hospital hospital = hospitalRepository.Hospitals
                .FirstOrDefault(h => h.HospitalId == hospitalId);
            return View(hospital);
        }

        [HttpPost]
        public ActionResult Edit(Hospital hospital)
        {
            if (ModelState.IsValid)
            {
                hospitalRepository.Save(hospital);
                TempData["message"] = string.Format("{0} 已经保存", hospital.HospitalId);
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(hospital);
            }
        }

        public ActionResult Delete(int hospitalId)
        {
            Hospital hospital = hospitalRepository.Delete(hospitalId);
            if (hospital != null)
            {
                TempData["message"] = string.Format("{0} 已经删除",
                    hospitalId);
            }
            return RedirectToAction("Index");
        }
    }
}