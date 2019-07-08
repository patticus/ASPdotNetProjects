using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace firstProject.Controllers
{
    public class ClassListController : Controller
    {
        // GET: ClassList
        public ActionResult Index()
        {
            string[] Classes = {".NET Framework", "Business Applications", "Data Structures and Algorithms", "SQL Databases", "Web Design"};
            ViewBag.Classes = Classes;
            return View();
        }
    }
}