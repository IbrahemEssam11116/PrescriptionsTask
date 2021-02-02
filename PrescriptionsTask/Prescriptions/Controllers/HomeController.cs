using Prescriptions.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prescriptions.Controllers
{
    public class HomeController : Controller
    {
        PrescriptionCotext DB ;
        public HomeController( )
        {
            DB = new PrescriptionCotext();
        }
        public ActionResult Index(DateTime?DateTO,DateTime? DateFrom, string PationData, int? DoctorID)
        {
            HomeViewModel  model= new HomeViewModel();
            model.RX = DB.Rxs.Include(w=>w.Doctor).Include(w=>w.Pation).ToList();
            if (!(DoctorID is null))
            {
                model.RX = model.RX.Where(w => w.DoctorID==DoctorID).ToList();
                model.DoctorID = DoctorID;
            }
            if (!String.IsNullOrEmpty(PationData))
                {
             model.RX= model.RX.Where(w => w.Pation.Name.Contains(PationData) ||w.Pation.Phone.Contains(PationData)).ToList();
                model.PationData = PationData;
            }
            if (!(DateTO is null))
            {
                model.RX = model.RX.Where(w=>w.DateTo >= DateTO).ToList();
                model.DateTO = DateTime.Now;
            }
            if (!(DateFrom is null))
            {
                model.RX = model.RX.Where(w => w.DateFrom <= DateFrom).ToList();
                model.DateFrom = DateFrom;
            }
            model.DoctorList = new SelectList(DB.Doctors.ToList(), "ID", "Name", model.DoctorID);

            return View(model);
        }

       public ActionResult GetRxDetail(int ID) 
        {
            var Rx = DB.Rxs.Where(w=>w.ID==ID).Include(w=>w.Doctor).Include(w=>w.Pation).Include(w=>w.Clinic).Include(w=>w.RxDetails).FirstOrDefault();

            return View(Rx);
        }
    }
}