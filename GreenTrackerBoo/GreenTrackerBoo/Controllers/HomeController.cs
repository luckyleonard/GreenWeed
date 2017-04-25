using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GreenTrackerBoo.Controllers
{
    //This is the major controller for return the view for main pages.
    public class HomeController : Controller
    {
        //method for return the Index page view
        public ActionResult Index()
        {
            ViewBag.Title="Green Tracker";
            return View();
        }

        public ActionResult AboutUs()
        {
            ViewBag.Title = "About Us";
            return View();
        }

        public ActionResult Report()
        {
            ViewBag.Title = "Report My Finding";
            return View();
        }

        public ActionResult Explore()
        {
            ViewBag.Title = "Explore My Area";
            return View();
        }


    }
}