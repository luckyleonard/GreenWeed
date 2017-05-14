using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GreenTrackerBoo.Models;
using System.Net;
using System.Net.Mail;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq; 

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

        public ActionResult GetStarted()
        {
            ViewBag.Title = "Get Started";
            return View();
        }

        public ActionResult AboutUs()
        {
            ViewBag.Title = "About Us";
            return View();
        }

        public ActionResult Quiz()
        {
            ViewBag.Title = "Quiz";
            return View();
        }

    
        public ActionResult Report()
        {
            ViewBag.Title = "Report My Finding";           

            return View();
        }

        private PlantContext db = new PlantContext();

        [HttpPost]
        public ActionResult Report(FormCollection formCollection)
        {
            var report = new Report();
            report.ReportLon = float.Parse(formCollection["Longitude"]);
            report.ReportLat = float.Parse(formCollection["Latitude1"]);
            report.PlantID = formCollection["CommonName"];
            report.AdditionalMessage = formCollection["AddMsg"];
            report.userEmail = formCollection["Email"];
            report.userName = formCollection["Name"];
            report.ReportDate = DateTime.Now.ToString("dd/MM/yyyy");
            db.Reports.Add(report);
            db.SaveChanges();

            MailMessage mail = new MailMessage();
            mail.To.Add(formCollection["Email"]);
            var test = formCollection["Email"];

            mail.From = new MailAddress("sxin14@student.monash.edu");
            mail.Subject = "Report Confirmation";
            string Body = "Hi " + formCollection["Name"] + " :"
                + "</br>" + "Thank You! Your report is successful :)" +
                "</br>" + "Check more about invasive plants!"
                + "</br>" + "https://greentracker.azurewebsites.net";
            mail.Body = Body;
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential
            ("sxin14@student.monash.edu", "Yangshu1517");// Enter seders User name and password
            smtp.EnableSsl = true;
            smtp.Send(mail);

 
            return View();
        }

        public ActionResult Library()
        {
            ViewBag.Title = "Plant Library";
            return View();
        }

        public ActionResult ViewReport()
        {
            ViewBag.Title = "View All Reports";
            var reports = db.Reports.Include("plant").ToList();
            return View(reports);
        }

        public ActionResult externalLink()
        {
            ViewBag.Title = "External Resources";
            return View();
        }

    }
}