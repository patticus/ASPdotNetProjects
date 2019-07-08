using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chapter3_Views.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "The tallest man on earth";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "The tallest man on earth";


            return View();
        }

        public ActionResult Rain(string weather, string Alert)
        {
            ViewBag.Message = "Rain.";
            ViewBag.Weather = "The weekend Forecast";
            ViewBag.Alert = "Red Flag on the beach";

            return View();
        }
    }
}