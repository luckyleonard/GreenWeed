using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text.RegularExpressions;


//This is the major controller for return the view for all pages.
namespace GREENWEED_4.Controllers
{
    public class HomeController : Controller
    {
        //method for return the Index page view
        public ActionResult Index()
        {
            return View();
        }

        //method for return the Plant1 page view
        public ActionResult AlligatorWeed()
        {
            ViewBag.Message = "Alligator Weed.";
            return View();
        }
    }
}