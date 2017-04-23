using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GreenTrackerBoo.Models;
using System.Data.Entity;

namespace GreenTrackerBoo.Controllers
{
    public class OccurrencesController : Controller
    {
        private PlantContext db = new PlantContext();

        // GET: Occurrences
        public ActionResult TestResult()
        {
            var occurrences = db.Occurrences.Include("plant").ToList();
            //var occurrences = db.Occurrences.ToList();
            return View(occurrences);
        }

        public JsonResult GetAllLocation()
        {
            using (db)
            {
                var v = db.Occurrences.ToList();
                return new JsonResult { Data = v, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }

        public JsonResult GetMarkerInfo(int OccurID)
        {
            using (db)
            {
                Occurrence o = null;
                o = db.Occurrences.Where(a => a.OccurID.Equals(OccurID)).FirstOrDefault();
                return new JsonResult { Data = o, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }
    }
}