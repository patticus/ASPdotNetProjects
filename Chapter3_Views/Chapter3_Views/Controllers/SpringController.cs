using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chapter3_Views.Controllers
{
    public class SpringController : Controller
    {
        // GET: Spring
        public ActionResult Index()
        {
            return View();
        }
    }
}