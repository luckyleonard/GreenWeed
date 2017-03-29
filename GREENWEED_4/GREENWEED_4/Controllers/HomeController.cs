using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text.RegularExpressions;


namespace GREENWEED_4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Plant1()
        {
            ViewBag.Message = "Plant1 page.";
            return View();
        }

        public ActionResult SearchResult()
        {
            ViewBag.Message = "SearchResult page.";
            return View();
        }

    }
}