using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharp_Net_module3_1_1_lab.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Income()
        {
            ViewBag.Message = "Your income description page.";

            return View();
        }

        public ActionResult Calculator()
        {
            ViewBag.Message = "Your calculator.";

            return View();
        }

        public ActionResult Vacations()
        {
            ViewBag.Message = "Your vacations page.";

            return View();
        }
    }
}